using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace IMailAccess
{
    public partial class Indicator : Form
    {
        private int PgSize = 10;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        private const string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Indicator\IDK.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        /*
       * CONSTRUCTOR
       */
        public Indicator()
        {
            InitializeComponent();
            //DATAGRIDVIEW PROPERTIES
            ListDataGridView.ColumnCount = 7;
            ListDataGridView.Columns[0].Name = "شماره ثبت";
            ListDataGridView.Columns[1].Name = "شماره نامه";
            ListDataGridView.Columns[2].Name = "تاریخ نامه";
            ListDataGridView.Columns[3].Name = "سازمان";
            ListDataGridView.Columns[4].Name = "عنوان نامه";
            ListDataGridView.Columns[5].Name = "جزئیات";
            ListDataGridView.Columns[6].Name = "نوع نامه";
            ListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            ListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ListDataGridView.MultiSelect = false;
            dateTimeSelector1.UsePersianFormat = true;
            Retrieve(1);
        }
        private void Indicator_Load(object sender, EventArgs e)
        {
            CalculateTotalPages();
        }
        private void CalculateTotalPages()
        {
            string sql = "SELECT * FROM [Indicator]";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                //CLEAR DATATABLE
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            int rowCount = dt.Rows.Count;
            TotalPage = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
            {
                TotalPage += 1;
            }
            dt.Rows.Clear();
        }


        /*
         * ADD BUTTON CLICKED
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Mailno = Convert.ToInt32(MailNoTextBox.Text);

                DateTime MailDate;
                DateTime? Mdate = dateTimeSelector1.Value;
                try
                {
                    MailDate = Mdate.Value;
                    string title = TitleTextBox.Text;
                    string organization = OrganizationTextbox.Text;
                    string details = DetailsTextBox.Text;
                    bool isin = IsInCheckBox.Checked;
                    Add(Mailno, MailDate, title, organization, details, isin);
                }
                catch
                {
                    MessageBox.Show("مقدار تاریخ صحیح وارد نشده است");
                }
                CalculateTotalPages();
                Retrieve(1);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("مقادیر را درست وارد کنید\n" + ex.Message);
            }
        }
        /*
        * INSERT INTO DATABASE
        */
        private void Add(int MailNo, DateTime MailDate, string Organization, string Title, string Details, bool IsIn)
        {
            //SQL STRING
            const string sql = "INSERT INTO [Indicator]([MailNo],[MailDate],[Title],[Organization],[Details],[IsIn]) VALUES(@MailNo,@MailDate,@Organization,@Title,@Details,@IsIn)";
            cmd = new OleDbCommand(sql, con);
            //ADD PARAMS
            cmd.Parameters.AddWithValue("@MailNo", MailNo);
            cmd.Parameters.AddWithValue("@MailDate", MailDate);
            cmd.Parameters.AddWithValue("@Organization", Organization);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.Parameters.AddWithValue("@IsIn", IsIn);
            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    ClearTexts();
                    MessageBox.Show("ثبت با موفقیت انجام شد");
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطایی رخ داد، دوباره تلاش کنید");
                con.Close();
            }
        }

        /*
         * SEARCH BUTTON CLICKED
         */
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int mailno = Convert.ToInt32(SearchTextBox.Text);
                string sql = "SELECT * FROM [Indicator] WHERE MailNo=@MailNo";
                cmd = new OleDbCommand(sql, con);
                cmd.Parameters.AddWithValue("@MailNo", mailno);
                try
                {
                    con.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    ListDataGridView.Rows.Clear();
                    ShowResultLabel.Text = dt.Rows.Count + " = تعداد رکورد های یافت شده";
                    foreach (DataRow row in dt.Rows)
                    {
                        Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                    }
                    //CLEAR DATATABLE
                    dt.Rows.Clear();
                    PageLabel.Text = "نتیجه جستجو";
                }
                catch (Exception)
                {
                    MessageBox.Show("خطایی رخ داد، دوباره تلاش کنید");
                    con.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("شماره نامه درست وارد نشده است\n" + ex.Message);
            }
        }
        
        /*
         * UPDATE BUTTON CLICKED
         */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = ListDataGridView.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    String selected = ListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(selected);
                    int mailno = Convert.ToInt32(MailNoTextBox.Text);
                    bool isin = Convert.ToBoolean(IsInCheckBox.Checked);

                    DateTime MailDate;
                    DateTime? Mdate = dateTimeSelector1.Value;
                    try
                    {
                        MailDate = Mdate.Value;
                        Update(id, mailno, MailDate, TitleTextBox.Text, OrganizationTextbox.Text, DetailsTextBox.Text, isin);
                    }
                    catch
                    {
                        MessageBox.Show("مقدار تاریخ صحیح وارد نشده است");
                    }
                    Retrieve(1);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("خطایی رخ داد\n" + ex.Message);
            }
        }
        /*
          *  UPDATE DATABASE
         */
        private void Update(int id, int mailno, DateTime maildate, string title, string organization, string details, bool isin)
        {
            //SQL STATEMENT

            string sql = "UPDATE [Indicator] SET [MailNo]=@MailNo, [MailDate]=@MailDate, [Title]=@Title, [Organization]=@Organization, [Details]=@Details, [IsIn]=@IsIn WHERE ID=@id";
            cmd = new OleDbCommand(sql, con);
            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.Parameters.AddWithValue("@MailNo", mailno);
                adapter.UpdateCommand.Parameters.AddWithValue("@MailDate", maildate);
                adapter.UpdateCommand.Parameters.AddWithValue("@Organization", organization);
                adapter.UpdateCommand.Parameters.AddWithValue("@Title", title);
                adapter.UpdateCommand.Parameters.AddWithValue("@Details", details);
                adapter.UpdateCommand.Parameters.AddWithValue("@IsIn", isin);
                adapter.UpdateCommand.Parameters.AddWithValue("@id", id);
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    ClearTexts();
                    MessageBox.Show(@"به روز رسانی با موفقیت انجام شد");
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("مقادیر را درست وارد کنید");
                con.Close();
            }
        }

        /*
         * DELETE BUTTON CLICKED
         */
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = ListDataGridView.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    String selected = ListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(selected);
                    Delete(id);
                    Retrieve(1);
                    ClearTexts();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("خطایی رخ داد\n" + ex.Message);
            }
        }
        /*
         * DELETE FROM DATABASE
         */
        private void Delete(int id)
        {
            //SQL STATEMENTT
            String sql = "DELETE FROM [Indicator] WHERE ID=" + id + "";
            cmd = new OleDbCommand(sql, con);
            //'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    DeleteCommand = con.CreateCommand()
                };
                adapter.DeleteCommand.CommandText = sql;
                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"آیا رکورد مورد نظر حذف شود ؟", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"رکورد مورد نظر با موفقیت حذف شد");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد، دوباره تلاش کنید");
                con.Close();
            }
        }

        /*
         * CLEAR BUTTON CLICKED
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTexts();
        }
        /*
         * CLEAR TEXTBOXES
         */
        private void ClearTexts()
        {
            ShowResultLabel.Text = "";
            MailNoTextBox.Text = "";
            TitleTextBox.Text = "";
            OrganizationTextbox.Text = "";
            dateTimeSelector1.Value = null;
            DetailsTextBox.Text = "";
            IsInCheckBox.Checked = false;
        }

        private void ListDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int selectedIndex = ListDataGridView.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (ListDataGridView.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = Convert.ToInt32(ListDataGridView.SelectedRows[0].Cells[0].Value);
                        int mailno = Convert.ToInt32(ListDataGridView.SelectedRows[0].Cells[1].Value);
                        DateTime mdate = Convert.ToDateTime(ListDataGridView.SelectedRows[0].Cells[2].Value);
                        DateTime maildate = mdate.ToMiladi();
                        string title = ListDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                        string organization = ListDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                        string details = ListDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                        string isin = ListDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                        MailNoTextBox.Text = mailno.ToString();
                        dateTimeSelector1.Value = maildate;
                        TitleTextBox.Text = title;
                        OrganizationTextbox.Text = organization;
                        DetailsTextBox.Text = details;
                        if (isin == "دریافتی")
                        {
                            IsInCheckBox.Checked = true;
                        }
                        else
                        {
                            IsInCheckBox.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد\n" + ex.Message);
            }
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = 1;
            Retrieve(CurrentPageIndex);
            ClearTexts();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPageIndex > 1)
            {
                CurrentPageIndex--;
            }
            else
            {
                CurrentPageIndex = TotalPage;
            }
            Retrieve(CurrentPageIndex);
            ClearTexts();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPageIndex < TotalPage)
            {
                CurrentPageIndex++;
            }
            else
            {
                CurrentPageIndex = 1;
            }
            Retrieve(CurrentPageIndex);
            ClearTexts();
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageIndex = TotalPage;
            Retrieve(CurrentPageIndex);
            ClearTexts();
        }
        /*
         * RETRIEVAL OF DATA
         */
        private void Retrieve(int page)
        {
            ListDataGridView.Rows.Clear();
            //SQL STATEMENT
            String sql;
            if (page == 1)
            {
                sql = "Select TOP " + PgSize + " * from [Indicator] ORDER BY ID";
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PgSize;

                sql = "Select TOP " + PgSize +
                    " * from [Indicator] WHERE ID NOT IN " +
                    "(Select TOP " + PreviousPageOffSet +
            " ID from [Indicator] ORDER BY ID) ";
            }
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                foreach (DataRow row in dt.Rows)
                {
                    Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
                }
                //CLEAR DATATABLE
                dt.Rows.Clear();
                PageLabel.Text = page.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی رخ داد\n"+ex.Message);
                con.Close();
            }
        }
        /*
         * FILL DATAGRIDVIEW
         */
        private void Populate(string id, string MailNo, string MailDate, string Title, string Organization, string Details, string IsIn)
        {
            string type;
            if (IsIn != "True")
            {
                type = "ارسالی";
            }
            else
            {
                type = "دریافتی";
            }

            DateTime MD = Convert.ToDateTime(MailDate);
            string date = MD.ToJalaliFormatted();

            ListDataGridView.Rows.Add(id, MailNo, date, Title, Organization, Details, type);
        }
    }
}