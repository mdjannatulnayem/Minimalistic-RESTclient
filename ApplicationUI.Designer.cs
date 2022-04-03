namespace REST_Client
{
    partial class ApplicationUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.url = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.methodSelect = new System.Windows.Forms.ComboBox();
            this.q_result = new System.Windows.Forms.RichTextBox();
            this.jsontext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(3, 12);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(450, 21);
            this.url.TabIndex = 0;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Gray;
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(545, 11);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Gray;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(626, 11);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // methodSelect
            // 
            this.methodSelect.FormattingEnabled = true;
            this.methodSelect.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.methodSelect.Location = new System.Drawing.Point(459, 12);
            this.methodSelect.Name = "methodSelect";
            this.methodSelect.Size = new System.Drawing.Size(80, 23);
            this.methodSelect.TabIndex = 3;
            // 
            // q_result
            // 
            this.q_result.Location = new System.Drawing.Point(3, 41);
            this.q_result.Name = "q_result";
            this.q_result.Size = new System.Drawing.Size(450, 406);
            this.q_result.TabIndex = 4;
            this.q_result.Text = "";
            // 
            // jsontext
            // 
            this.jsontext.Location = new System.Drawing.Point(459, 41);
            this.jsontext.Name = "jsontext";
            this.jsontext.Size = new System.Drawing.Size(242, 406);
            this.jsontext.TabIndex = 5;
            this.jsontext.Text = "";
            // 
            // ApplicationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.jsontext);
            this.Controls.Add(this.q_result);
            this.Controls.Add(this.methodSelect);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.send);
            this.Controls.Add(this.url);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "ApplicationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimalistic REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox methodSelect;
        private System.Windows.Forms.RichTextBox q_result;
        private System.Windows.Forms.RichTextBox jsontext;
    }
}
