using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sistema_de_Inventario_SC
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Here I am overriding Paint method of form object
        /// and set it's background color as gradient. Here I am
        /// using LinearGradientBrush class object to make gradient
        /// color which comes in System.Drawing.Drawing2D namespace.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.SkyBlue, Color.AliceBlue, 60);
            e.Graphics.FillRectangle(brush, rect);
            base.OnPaint(e);
        }

        /// <summary>
        /// setMessage method is used to display message
        /// on form and it's height adjust automatically.
        /// I am displaying message in a Label control.
        /// </summary>
        /// <param name="messageText">Message which needs to be displayed to user.</param>
        private void setMessage(string messageText)
        {
            int number = Math.Abs(messageText.Length / 30);
            if (number != 0)
                this.lblMessageText.Height = number * 25;
            this.lblMessageText.Text = messageText;
            this.Width = lblMessageText.Size.Width + 40;
        }



        /// <summary>
        /// This method is used to add button on message box.
        /// </summary>
        /// <param name="MessageButton">MessageButton is type of enumMessageButton
        /// through which I get type of button which needs to be displayed.</param>
        private void addButton(enumMessageButton MessageButton)
        {
            switch (MessageButton)
            {
                case enumMessageButton.OK:
                    {
                        Button btnOk = new Button();
                        btnOk.Text = "Ok";
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Flat;
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.BackColor = Color.FromArgb(193, 220, 34);
                        btnOk.Font = new Font(new FontFamily("Arial"), 14);
                        btnOk.ForeColor = Color.Black;
                        btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnOk.SetBounds((pnlShowMessage.ClientSize.Width - 130), 15, 112, 44);
                        botonPanel.Controls.Add(btnOk);
                    }
                    break;
                case enumMessageButton.OKCancel:
                    {
                        Button btnOk = new Button();
                        btnOk.Text = "Ok";
                        btnOk.DialogResult = DialogResult.OK;
                        btnOk.FlatStyle = FlatStyle.Flat;
                        btnOk.FlatAppearance.BorderSize = 0;
                        btnOk.BackColor = Color.FromArgb(193, 220, 34);
                        btnOk.Font = new Font(new FontFamily("Arial"), 14);
                        btnOk.ForeColor = Color.Black;
                        btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnOk.SetBounds((pnlShowMessage.ClientSize.Width - 130), 15, 112, 44);
                        botonPanel.Controls.Add(btnOk);

                        Button btnCancel = new Button();
                        btnCancel.Text = "Cancelar";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Flat;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.BackColor = Color.FromArgb(193, 220, 34);
                        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnCancel.ForeColor = Color.Black;
                        btnCancel.Font = new Font(new FontFamily("Arial"), 14);
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - (btnOk.ClientSize.Width + 10 + 140)), 15, 112, 44);
                        botonPanel.Controls.Add(btnCancel);

                    }
                    break;
                case enumMessageButton.YesNo:
                    {
                        Button btnNO = new Button();
                        btnNO.Text = "No";
                        btnNO.DialogResult = DialogResult.No;
                        btnNO.FlatStyle = FlatStyle.Flat;
                        btnNO.FlatAppearance.BorderSize = 0;
                        btnNO.BackColor = Color.FromArgb(193, 220, 34);
                        btnNO.Font = new Font(new FontFamily("Arial"), 14);
                        btnNO.ForeColor = Color.Black;
                        btnNO.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnNO.SetBounds((pnlShowMessage.ClientSize.Width - 130), 15, 112, 44);
                        botonPanel.Controls.Add(btnNO);

                        Button btnYes = new Button();
                        btnYes.Text = "Si";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Flat;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.BackColor = Color.FromArgb(193, 220, 34);
                        btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnYes.ForeColor = Color.Black;
                        btnYes.Font = new Font(new FontFamily("Arial"), 14);
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnNO.ClientSize.Width + 10 + 140)), 15, 112, 44);
                        botonPanel.Controls.Add(btnYes);
                    }
                    break;
                case enumMessageButton.YesNoCancel:
                    {
                        Button btnCancel = new Button();
                        btnCancel.Text = "Cancelar";
                        btnCancel.DialogResult = DialogResult.Cancel;
                        btnCancel.FlatStyle = FlatStyle.Flat;
                        btnCancel.FlatAppearance.BorderSize = 0;
                        btnCancel.BackColor = Color.FromArgb(193, 220, 34);
                        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnCancel.ForeColor = Color.Black;
                        btnCancel.Font = new Font(new FontFamily("Arial"), 14);
                        btnCancel.SetBounds((pnlShowMessage.ClientSize.Width - 130), 15, 112, 44);
                        botonPanel.Controls.Add(btnCancel);

                        Button btnNO = new Button();
                        btnNO.Text = "No";
                        btnNO.DialogResult = DialogResult.No;
                        btnNO.FlatStyle = FlatStyle.Flat;
                        btnNO.FlatAppearance.BorderSize = 0;
                        btnNO.BackColor = Color.FromArgb(193, 220, 34);
                        btnNO.Font = new Font(new FontFamily("Arial"), 14);
                        btnNO.ForeColor = Color.Black;
                        btnNO.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnNO.SetBounds((pnlShowMessage.ClientSize.Width - (btnNO.ClientSize.Width + 10 + 180)), 15, 112, 44);
                        botonPanel.Controls.Add(btnNO);

                        Button btnYes = new Button();
                        btnYes.Text = "Si";
                        btnYes.DialogResult = DialogResult.Yes;
                        btnYes.FlatStyle = FlatStyle.Flat;
                        btnYes.FlatAppearance.BorderSize = 0;
                        btnYes.BackColor = Color.FromArgb(193, 220, 34);
                        btnYes.Font = new Font(new FontFamily("Arial"), 14);
                        btnYes.ForeColor = Color.Black;
                        btnYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 112, 1);
                        btnYes.SetBounds((pnlShowMessage.ClientSize.Width - (btnCancel.ClientSize.Width + btnNO.ClientSize.Width + +10 + 165)), 15, 112, 44);
                        botonPanel.Controls.Add(btnYes);
                    }
                    break;
            }
        }

        /// <summary>
        /// We can use this method to add image on message box.
        /// I had taken all images in ImageList control so that
        /// I can eaily add images. Image is displayed in
        /// PictureBox control.
        /// </summary>
        /// <param name="MessageIcon">Type of image to be displayed.</param>
        private void addIconImage(enumMessageIcon MessageIcon)
        {
            switch (MessageIcon)
            {
                case enumMessageIcon.Error:
                    //pictureBox1.Image = MessageBoxIcon.Error;  //Error is key name in imagelist control which uniqly identified images in ImageList control.
                    break;
                case enumMessageIcon.Information:
                    //pictureBox1.Image = imageList1.Images["Information"];
                    break;
                case enumMessageIcon.Question:
                    // pictureBox1.Image = imageList1.Images["Question"];
                    break;
                case enumMessageIcon.Warning:
                    // pictureBox1.Image = imageList1.Images["Warning"];
                    break;
            }
        }

        #region Overloaded Show message to display message box.

        /// <summary>
        /// Show method is overloaded which is used to display message
        /// and this is static method so that we don't need to create
        /// object of this class to call this method.
        /// </summary>
        /// <param name="messageText"></param>
        internal static DialogResult Show(string messageText)
        {
            MessageForm frmMessage = new MessageForm();
            frmMessage.setMessage(messageText);
            frmMessage.addIconImage(enumMessageIcon.Information);
            frmMessage.addButton(enumMessageButton.OK);
            frmMessage.ShowDialog();
            return frmMessage.DialogResult;
        }

        internal static DialogResult Show(string messageText, string messageTitle)
        {
            MessageForm frmMessage = new MessageForm();
            frmMessage.Text = messageTitle;
            frmMessage.setMessage(messageText);
            frmMessage.addIconImage(enumMessageIcon.Information);
            frmMessage.addButton(enumMessageButton.OK);
            frmMessage.ShowDialog();
            return frmMessage.DialogResult;
        }

        internal static DialogResult Show(string messageText, string messageTitle, enumMessageIcon messageIcon, enumMessageButton messageButton)
        {
            MessageForm frmMessage = new MessageForm();
            frmMessage.setMessage(messageText);
            frmMessage.Text = messageTitle;
            frmMessage.addIconImage(messageIcon);
            frmMessage.addButton(messageButton);
            frmMessage.ShowDialog();
            return frmMessage.DialogResult;
        }

        #endregion

        private void MessageForm_Load_1(object sender, EventArgs e)
        {
            lbTitulo.Text = this.Text;
        }

    }

    #region constant defiend in form of enumration which is used in showMessage class.

    internal enum enumMessageIcon
    {
        Error,
        Warning,
        Information,
        Question,
    }

    internal enum enumMessageButton
    {
        OK,
        YesNo,
        YesNoCancel,
        OKCancel
    }

    #endregion
}