using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using customers;

namespace customerWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string Result1 = "Статус";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Result1;
        }
        //add
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление товара
                Customer cust = new Customer();
                cust._insert(TextBox1.Text,TextBox2.Text,TextBox3.Text);
                Result1 = "Добавлен новый гость";
                Response.Redirect("WebForm1.aspx");
            }
            catch (Exception)
            {
                Label1.Text = "Введены недопустимые данные";
            }
        }
        //edit
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIndex = GridView1.SelectedIndex;
                if (SelectedIndex < 0)
                {
                    Result1 = "Ничего не выбрано";
                    return;
                }
                int id;
                id = Convert.ToInt32(GridView1.Rows[SelectedIndex].Cells[1].Text);
                Customer cust = new Customer();
                cust._update(id, TextBox1.Text,TextBox2.Text,TextBox3.Text);
                Result1 = "Изменения успешно внесены";
                Response.Redirect("WebForm1.aspx");
            }
            catch (Exception)
            {
                Label1.Text = "Введены недопустимые данные";
            }
        }
        //delete
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIndex = GridView1.SelectedIndex;
                if (SelectedIndex < 0)
                {
                    Result1 = "Ничего не выбрано";
                    return;
                }
                //Удаление товара
                int id;
                id = Convert.ToInt32(GridView1.Rows[SelectedIndex].Cells[1].Text);
                Customer cust = new Customer();
                cust._delete(id);
                Result1 = "Удаление товара прошло успешно";
                Response.Redirect("WebForm1.aspx");

            }
            catch (Exception)
            {
                Label1.Text = "Невозможно удалить элемент, нарушение целостности данных";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FIO, Passport, Requisites;
            int SelectedIndex = GridView1.SelectedIndex;
            FIO = GridView1.Rows[SelectedIndex].Cells[2].Text;
            Passport = GridView1.Rows[SelectedIndex].Cells[3].Text;
            Requisites = GridView1.Rows[SelectedIndex].Cells[4].Text;
            TextBox1.Text = FIO;
            TextBox2.Text = Passport;
            TextBox3.Text = Requisites;
        }
    }
}