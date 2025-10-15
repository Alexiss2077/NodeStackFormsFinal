namespace NodeStackssForms
{
    partial class Form1
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
            txtId = new TextBox();
            btnAdd = new Button();
            btnPeek = new Button();
            btnRemove = new Button();
            btnCount = new Button();
            txtContent = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(75, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(307, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 89);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add (Push)";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(307, 189);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(169, 89);
            btnPeek.TabIndex = 2;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(307, 336);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(169, 89);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove (Pop)";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(307, 476);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(169, 89);
            btnCount.TabIndex = 4;
            btnCount.Text = "Contains";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(604, 45);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(440, 486);
            txtContent.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(75, 235);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 85);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 161);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 242);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "Phone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 605);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtContent);
            Controls.Add(btnCount);
            Controls.Add(btnRemove);
            Controls.Add(btnPeek);
            Controls.Add(btnAdd);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Button btnAdd;
        private Button btnPeek;
        private Button btnRemove;
        private Button btnCount;
        private TextBox txtContent;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
