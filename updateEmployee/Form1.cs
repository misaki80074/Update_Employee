using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace updateEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        private void Form1_Load(object sender, EventArgs e)
        {
            // 載入資料
            adapter.Fill(ds.DimEmployee);

            // 新增 full name 欄位，顯示欄位名稱叫 Name，用來合併 first name 和 last name
            DataGridViewTextBoxColumn fullNameCol = new DataGridViewTextBoxColumn();
            fullNameCol.HeaderText = "Name";
            fullNameCol.Name = "Name";
            Employee_list.Columns.Add(fullNameCol);

            // 設定 開啟檔案 的屬性
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Open an Image";
            openFileDialog1.Filter = "Image File(*.JPG;*.PNG)|*.JPG;*.PNG";
        }
        //------------------------------------------------------------------------
        // Update tab
        private void Employee_list_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 合併 FirstName 和 LastName
            if (e.ColumnIndex == Employee_list.Columns["Name"].Index)
            {
                e.Value = $"{Employee_list.Rows[e.RowIndex].Cells[5].Value} {Employee_list.Rows[e.RowIndex].Cells[6].Value}";
            }

            
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            // 開啟圖片後，放在預覽的框框內
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                imgPath_textbox.Text = openFileDialog1.FileName;
                reviewImg_picturebox.Image = Image.FromFile(imgPath_textbox.Text);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // 取得資料表的位置
            int position = bindingSource1.Position;

            // 依照 textbox 的 text 更新資料
            AdventureWorksDW2019DataSet.DimEmployeeRow dr = ds.DimEmployee[position];
            dr.FirstName = firstName.Text;
            dr.LastName = lastName.Text;
            dr.Gender = gender.Text;
            dr.EmailAddress = emailAddr.Text;
            dr.Phone = phone.Text;
            dr.HireDate = Convert.ToDateTime(hireDate.Text);

            if (endDate.Text == "")
                endDate.Text = null;
            else
                dr.EndDate = Convert.ToDateTime(endDate.Text);

            dr.DepartmentName = department.Text;
            dr.Title = title.Text;

            if (imgPath_textbox.Text != "")
            {
                byte[] img = null;
                FileStream stream = new FileStream(imgPath_textbox.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                img = br.ReadBytes((int)stream.Length);
                dr.EmployeePhoto = img;
            }

            // bindingSource 更新
            bindingSource1.Position += 1;
            bindingSource1.Position -= 1;

            // 上傳
            adapter.Update(ds.DimEmployee);
            
            // datagridview 更新
            Employee_list.Update();
            Employee_list.Refresh();

            imgPath_textbox.Text = "";
            reviewImg_picturebox.Image = null;


			MessageBox.Show("Update Completed!");

        }
        
        // ---------------------------------------------------------
        // Increase tab
        private void clear_btn_Click(object sender, EventArgs e)
        {
            // textbox5 = 0
            // textBox18 = Current
            // textBox19 = 1

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "0";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "Current";
            textBox19.Text = "1";
            textBox20.Text = "";

            label32.Text = "";
            insertImg.Image = null;
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label32.Text = openFileDialog1.FileName;
                insertImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            // 新增資料
            AdventureWorksDW2019DataSet.DimEmployeeRow newPerson = ds.DimEmployee.NewDimEmployeeRow();

            if (InsertData(newPerson))
            {
                ds.DimEmployee.AddDimEmployeeRow(newPerson);
            }


            adapter.Update(ds.DimEmployee);
            
            Employee_list.Update();
            Employee_list.Refresh();

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            // 當 Title 是 Sales 時，顯示 1，其餘顯示 0
            if(textBox10.Text.ToUpper().Contains("SALES"))
                textBox20.Text = "1";
            else
                textBox20.Text = "0";
        }

        private void LoginID_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int countFirstName = ds.DimEmployee.Count(p => p.FirstName == textBox2.Text);
                textBox12.Text = $"adventure-works\\{textBox2.Text.ToLower()}{countFirstName}";
                textBox13.Text = $"{textBox2.Text.ToLower()}{countFirstName}@adventure-works.com";
            }
        }

        private bool InsertData(AdventureWorksDW2019DataSet.DimEmployeeRow newPerson)
        {
            // 判斷 null
            // FirstName、LastName、NameStyle、CurrentFlag、SalesPersonFlag 不可為 null
            // NameStyle、CurrentFlag、SalesPersonFlag 已經有預設，且有設定 enable = true

            // EmployeeNationalIDAlternateKey 是 null 時，隨意給 9 個數字
            if (textBox1.Text != "")
            {
                newPerson.EmployeeNationalIDAlternateKey = textBox1.Text;
            }
            else
            {
                Random random = new Random();
                int tempNationalID = random.Next(100000, 999999999);
                newPerson.EmployeeNationalIDAlternateKey = tempNationalID.ToString();
            }

            // FirstName、LastName 不可為 null
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                newPerson.FirstName =  textInfo.ToTitleCase(textBox2.Text);
                newPerson.LastName = textInfo.ToTitleCase(textBox3.Text);
            }
            else
            {
                MessageBox.Show("First name or last name can't be empty.");
                return false;
            }

            // MiddleName 可以為 null
            newPerson.MiddleName = textInfo.ToTitleCase(textBox4.Text);

            // NameStyle 固定為 0，型態為 bool
            newPerson.NameStyle = (textBox5.Text == "0") ? false : true;

            // Gender 在 SQL 可以為 null，但 C# 不允許，儲存值只有 M 或 F
            if (textBox6.Text != "")
            {
                string tempGender = textBox6.Text.ToUpper();
                if (tempGender == "M" || tempGender == "F")
                {
                    newPerson.Gender = textBox6.Text;
                }
                else
                {
                    MessageBox.Show("'Gender' only can be inputed 'M' or 'F'");
                    return false;
                }
            }
            else {
                MessageBox.Show("Gender can't be empty.");
                return false;
            }

            // BirthDate 可以為 null，但只要是人都有生日，所以改成必填
            if (textBox7.Text != "")
            {
                newPerson.BirthDate = Convert.ToDateTime(textBox7.Text);
            }
            else
            {
                MessageBox.Show("'Birth Date' can't be empty.");
                return false;
            }
                
            // Marital Status 可以為 null，儲存值只有 M 或 S
            if (textBox8.Text != "")
            {
                string tempMaritalStatus = textBox8.Text.ToUpper();
                if (tempMaritalStatus == "M" || tempMaritalStatus == "S")
                {
                    newPerson.MaritalStatus = textBox8.Text;
                }
                else
                {
                    MessageBox.Show("'Marital Status' only can be inputed 'M' or 'S'");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("'Marital Status' can't be empty");
                return false;
            }

            // DepartmentName可以為 null，但通常不會有 null
            string tempDepartmentName = textBox9.Text;
            if (textBox9.Text != "")
            {
                newPerson.DepartmentName = textInfo.ToTitleCase(tempDepartmentName);
            }
            else
            {
                MessageBox.Show("Department Name can't be empty");
                return false;
            }

            // Title 可以為 null，但通常不會有 null
            string tempTitle = textBox10.Text;
            if (textBox10.Text != "")
            {
                newPerson.Title = textInfo.ToTitleCase(tempTitle);
            }
            else
            {
                MessageBox.Show("Title can't be empty");
                return false;
            }

            // Phone 規格 XXX-XXX-XXXX
            bool phoneMatch = Regex.IsMatch(textBox11.Text, @"\d{3}-\d{3}-\d{4}$");
            if (phoneMatch)
            {
                newPerson.Phone = textBox11.Text;
            }
            else
            {
                MessageBox.Show("Format of phone is invalid.");
                return false;
            }

            // LoginID 可以為 null，規格 adventure-works\firstname + 1碼數字
            // firstname 全小寫
            // 1碼數字 從0開始，因為 firstname 可能會重複，所以要先知道 firstname 目前的數量，再來字串串接
            int countFirstName = ds.DimEmployee.Count(p => p.FirstName == textBox2.Text);
            newPerson.LoginID = $"adventure-works\\{textBox2.Text.ToLower()}{countFirstName}";

            // EmailAddress 可以為 null，規格 firstname + 1碼數字@adventure-works.com
            // firstname 全小寫
            newPerson.EmailAddress = $"{textBox2.Text.ToLower()}{countFirstName}@adventure-works.com";

            // HireDate、StartDate 可以為 null，但 C# 的 DateTime 型別不能儲存 null，當空白時就填寫今天的日期
            DateTime hireDate = (textBox14.Text != "") ? newPerson.HireDate = Convert.ToDateTime(textBox14.Text) : newPerson.HireDate = DateTime.Today;
            DateTime startDate = (textBox15.Text != "") ? newPerson.StartDate = Convert.ToDateTime(textBox15.Text) : newPerson.StartDate = DateTime.Today;

            // SalesTerritoryKey 要根據 Sales Territory 資料表做轉換
            switch ( textInfo.ToTitleCase(textBox16.Text) )
            {
                case "Northwest":
                    newPerson.SalesTerritoryKey = 1;
                    break;
                case "Northeast":
                    newPerson.SalesTerritoryKey = 2;
                    break;
                case "Central":
                    newPerson.SalesTerritoryKey = 3;
                    break;
                case "Southwest":
                    newPerson.SalesTerritoryKey = 4;
                    break;
                case "Southeast":
                    newPerson.SalesTerritoryKey = 5;
                    break;
                case "Canada":
                    newPerson.SalesTerritoryKey = 6;
                    break;
                case "France":
                    newPerson.SalesTerritoryKey = 7;
                    break;
                case "Germany":
                    newPerson.SalesTerritoryKey = 8;
                    break;
                case "Australia":
                    newPerson.SalesTerritoryKey = 9;
                    break;
                case "United Kingdom":
                    newPerson.SalesTerritoryKey = 10;
                    break;
                default:
                    newPerson.SalesTerritoryKey = 11;
                    break;
            }

            // PayFrequency 可以為 null，填寫只有 1 或 2
            // 但 C# 的 Byte 型態不能儲存 null，當 textBox17.Text 是空字串時預設為 1
            bool payFrequencyMatch = Regex.IsMatch(textBox17.Text, "[12]$");
            if (payFrequencyMatch)
                newPerson.PayFrequency = Convert.ToByte(textBox17.Text);
            else
                newPerson.PayFrequency = 1;

            // Status 預設 Current，不可修改，新增員工不可能 新增當下 就離職
            newPerson.Status = textBox18.Text;

            // CurrentFlag 預設 1，不可修改
            newPerson.CurrentFlag = (textBox19.Text == "1") ? true : false;

            // SalesPersonFlag 預設 0，Title 包含 Sales 時改為 1
            // Title_TextChanged() 會控制
            newPerson.SalesPersonFlag = (textBox20.Text == "1") ? true : false;

            if (label32.Text != "")
            {
                byte[] img = null;
                FileStream stream = new FileStream(label32.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                img = br.ReadBytes((int)stream.Length);
                newPerson.EmployeePhoto = img;
            }
            else {
                MessageBox.Show("You have to Upload Photo.");
                return false;
            }

            // EmergencyContactName = First Name + Last Name
            newPerson.EmergencyContactName = newPerson.FirstName + " " + newPerson.LastName;

            // EmergencyContactPhone = Phone
            newPerson.EmergencyContactPhone = newPerson.Phone;

            return true;

        }
    }
}
