namespace CRUDApp
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            tel = new TextBox();
            fb = new TextBox();
            save = new Button();
            cancel = new Button();
            id = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Tel.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Facebook";
            // 
            // name
            // 
            name.Location = new Point(96, 50);
            name.Name = "name";
            name.Size = new Size(132, 23);
            name.TabIndex = 3;
            // 
            // tel
            // 
            tel.Location = new Point(96, 87);
            tel.Name = "tel";
            tel.Size = new Size(132, 23);
            tel.TabIndex = 4;
            // 
            // fb
            // 
            fb.Location = new Point(96, 123);
            fb.Name = "fb";
            fb.Size = new Size(132, 23);
            fb.TabIndex = 5;
            // 
            // save
            // 
            save.Location = new Point(29, 166);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 6;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(153, 166);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(96, 15);
            id.Name = "id";
            id.Size = new Size(132, 23);
            id.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 18);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Student ID";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 201);
            Controls.Add(id);
            Controls.Add(label4);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(fb);
            Controls.Add(tel);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox tel;
        private TextBox fb;
        private Button save;
        private Button cancel;
        private TextBox id;
        private Label label4;
    }
}