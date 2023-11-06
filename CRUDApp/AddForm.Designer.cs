namespace CRUDApp
{
    partial class AddForm
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
            label4 = new Label();
            id = new TextBox();
            name = new TextBox();
            tel = new TextBox();
            fb = new TextBox();
            create = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 105);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Tel.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 146);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Facebook";
            // 
            // id
            // 
            id.Location = new Point(118, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 4;
            // 
            // name
            // 
            name.Location = new Point(118, 66);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 5;
            // 
            // tel
            // 
            tel.Location = new Point(118, 105);
            tel.Name = "tel";
            tel.Size = new Size(100, 23);
            tel.TabIndex = 6;
            // 
            // fb
            // 
            fb.Location = new Point(118, 143);
            fb.Name = "fb";
            fb.Size = new Size(100, 23);
            fb.TabIndex = 7;
            // 
            // create
            // 
            create.Location = new Point(26, 184);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 8;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(143, 184);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 9;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 221);
            Controls.Add(cancel);
            Controls.Add(create);
            Controls.Add(fb);
            Controls.Add(tel);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Add";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox id;
        private TextBox name;
        private TextBox tel;
        private TextBox fb;
        private Button create;
        private Button cancel;
    }
}