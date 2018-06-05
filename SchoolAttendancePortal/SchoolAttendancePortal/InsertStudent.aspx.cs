using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SchoolAttendancePortal
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            String strImage="";
            String message = "";
            StudentBLL studentBLL = new StudentBLL();


            if (String.IsNullOrEmpty(this.adminNumberTextBox.Text))
            {
                message += "Admin Number cannot be empty.";
            }
            else if (this.adminNumberTextBox.Text.Length != 7)
            {
                message += "Admin Number MUST be 7 characters";
            }

            if (String.IsNullOrEmpty(this.nameTextBox.Text))
            {
                message += "<BR>Name cannot be empty.";
            }

            if (String.IsNullOrEmpty(this.addressTextBox.Text))
            {
                message += "<BR>Address cannot be empty you idiot!.";
            }

            if (String.IsNullOrEmpty(this.mobileTextBox.Text))
            {
                message += "<BR>Mobile cannot be empty you idiot!.";
            }


            Student.Nationality citizenship = Student.Nationality.SG;
            switch (this.citizenshipDropDownList.SelectedValue)
            {
                case "SG":
                    citizenship = Student.Nationality.SG;
                    break;

                case "BD":
                    citizenship = Student.Nationality.BD;
                    break;

                case "CA":
                    citizenship = Student.Nationality.CA;
                    break;

                case "CN":
                    citizenship = Student.Nationality.CN;
                    break;

                case "HK":
                    citizenship = Student.Nationality.HK;
                    break;

                case "ID":
                    citizenship = Student.Nationality.ID;
                    break;

                case "JP":
                    citizenship = Student.Nationality.JP;
                    break;

                case "MY":
                    citizenship = Student.Nationality.MY;
                    break;
            }


            if (this.profileImageFileUpload.HasFile)
            {
                strImage = String.Format("Images{0}{1}", Path.DirectorySeparatorChar, this.profileImageFileUpload.FileName);
            }

            if (String.IsNullOrEmpty(message))
            {
                DateTime dob = DateTime.Today;

                if (DateTime.TryParse(this.dobTextBox.Text, out dob))
                {
                    if (DateTime.Today.Year - dob.Year >= 16)
                    {

                        String email = String.Format("{0}@mymail.nyp.edu.sg", this.adminNumberTextBox.Text);
                        //OR
                        String email1 = this.adminNumberTextBox.Text + "@mymail.nyp.edu.sg";



                        int iResult = studentBLL.InsertStudent(this.adminNumberTextBox.Text, this.nameTextBox.Text, this.genderRadioButtonList.SelectedValue, dob, this.addressTextBox.Text, citizenship, this.mobileTextBox.Text, email, strImage, out message);

                        if (iResult == 1)
                        {
                            message = String.Format("{0} has been registered successfully", this.nameTextBox.Text);

                            if (this.profileImageFileUpload.HasFile)
                            {
                                String strSaveImage = String.Format("{0}{1}", Server.MapPath("~"), strImage);
                                this.statusLabel.Text = strSaveImage.ToString();
                                profileImageFileUpload.SaveAs(strSaveImage);
                            }
                        }
                        else
                        {
                            message = "YOU LOOSE! GG LIAO";
                        }
                    }
                }

            }

            statusLabel.Text = message;


        }
    }
}