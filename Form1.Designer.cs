
namespace PR4
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Teacher = new System.Windows.Forms.Button();
            this.button_Position = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Member_circle = new System.Windows.Forms.Button();
            this.button_Shedule = new System.Windows.Forms.Button();
            this.button_Type_Circle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_Type_Circle);
            this.panel1.Controls.Add(this.button_Teacher);
            this.panel1.Controls.Add(this.button_Shedule);
            this.panel1.Controls.Add(this.button_Position);
            this.panel1.Controls.Add(this.button_Member_circle);
            this.panel1.Controls.Add(this.button_Circle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 450);
            this.panel2.TabIndex = 1;
            // 
            // button_Teacher
            // 
            this.button_Teacher.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Teacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Teacher.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.button_Teacher.Location = new System.Drawing.Point(0, 148);
            this.button_Teacher.Name = "button_Teacher";
            this.button_Teacher.Size = new System.Drawing.Size(204, 37);
            this.button_Teacher.TabIndex = 0;
            this.button_Teacher.Text = "Teacher";
            this.button_Teacher.UseVisualStyleBackColor = false;
            this.button_Teacher.Click += new System.EventHandler(this.button_Teacher_Click);
            // 
            // button_Position
            // 
            this.button_Position.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Position.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Position.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.button_Position.Location = new System.Drawing.Point(0, 74);
            this.button_Position.Name = "button_Position";
            this.button_Position.Size = new System.Drawing.Size(204, 37);
            this.button_Position.TabIndex = 1;
            this.button_Position.Text = "Position";
            this.button_Position.UseVisualStyleBackColor = false;
            this.button_Position.Click += new System.EventHandler(this.button_Position_Click);
            // 
            // button_Circle
            // 
            this.button_Circle.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Circle.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Circle.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Circle.Location = new System.Drawing.Point(0, 0);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Circle.Size = new System.Drawing.Size(204, 37);
            this.button_Circle.TabIndex = 2;
            this.button_Circle.Text = "Circle";
            this.button_Circle.UseVisualStyleBackColor = false;
            this.button_Circle.Click += new System.EventHandler(this.button_Circle_Click);
            // 
            // button_Member_circle
            // 
            this.button_Member_circle.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Member_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Member_circle.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Member_circle.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.button_Member_circle.Location = new System.Drawing.Point(0, 37);
            this.button_Member_circle.Name = "button_Member_circle";
            this.button_Member_circle.Size = new System.Drawing.Size(204, 37);
            this.button_Member_circle.TabIndex = 3;
            this.button_Member_circle.Text = "Member circle";
            this.button_Member_circle.UseVisualStyleBackColor = false;
            this.button_Member_circle.Click += new System.EventHandler(this.button_Member_circle_Click);
            // 
            // button_Shedule
            // 
            this.button_Shedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Shedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Shedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Shedule.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.button_Shedule.Location = new System.Drawing.Point(0, 111);
            this.button_Shedule.Name = "button_Shedule";
            this.button_Shedule.Size = new System.Drawing.Size(204, 37);
            this.button_Shedule.TabIndex = 4;
            this.button_Shedule.Text = "Shedule";
            this.button_Shedule.UseVisualStyleBackColor = false;
            this.button_Shedule.Click += new System.EventHandler(this.button_Shedule_Click);
            // 
            // button_Type_Circle
            // 
            this.button_Type_Circle.BackColor = System.Drawing.Color.DarkOrchid;
            this.button_Type_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Type_Circle.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Type_Circle.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.button_Type_Circle.Location = new System.Drawing.Point(0, 185);
            this.button_Type_Circle.Name = "button_Type_Circle";
            this.button_Type_Circle.Size = new System.Drawing.Size(204, 37);
            this.button_Type_Circle.TabIndex = 5;
            this.button_Type_Circle.Text = "Type circle";
            this.button_Type_Circle.UseVisualStyleBackColor = false;
            this.button_Type_Circle.Click += new System.EventHandler(this.button_Type_Circle_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Type_Circle;
        private System.Windows.Forms.Button button_Teacher;
        private System.Windows.Forms.Button button_Shedule;
        private System.Windows.Forms.Button button_Position;
        private System.Windows.Forms.Button button_Member_circle;
        private System.Windows.Forms.Button button_Circle;
        private System.Windows.Forms.Panel panel2;
    }
}

