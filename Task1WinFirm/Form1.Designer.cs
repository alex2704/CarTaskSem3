namespace Task1WinFirm
{
    partial class YourCar
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
            this.Btn_move = new System.Windows.Forms.Button();
            this.Btn_refuel = new System.Windows.Forms.Button();
            this.Btn_changeWheel = new System.Windows.Forms.Button();
            this.Btn_model = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_move
            // 
            this.Btn_move.Location = new System.Drawing.Point(993, 12);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(116, 53);
            this.Btn_move.TabIndex = 0;
            this.Btn_move.Text = "Ехать";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // Btn_refuel
            // 
            this.Btn_refuel.Location = new System.Drawing.Point(993, 93);
            this.Btn_refuel.Name = "Btn_refuel";
            this.Btn_refuel.Size = new System.Drawing.Size(116, 61);
            this.Btn_refuel.TabIndex = 1;
            this.Btn_refuel.Text = "Заправиться";
            this.Btn_refuel.UseVisualStyleBackColor = true;
            // 
            // Btn_changeWheel
            // 
            this.Btn_changeWheel.Location = new System.Drawing.Point(993, 182);
            this.Btn_changeWheel.Name = "Btn_changeWheel";
            this.Btn_changeWheel.Size = new System.Drawing.Size(116, 56);
            this.Btn_changeWheel.TabIndex = 2;
            this.Btn_changeWheel.Text = "Заменить колесо";
            this.Btn_changeWheel.UseVisualStyleBackColor = true;
            // 
            // Btn_model
            // 
            this.Btn_model.Location = new System.Drawing.Point(993, 269);
            this.Btn_model.Name = "Btn_model";
            this.Btn_model.Size = new System.Drawing.Size(116, 47);
            this.Btn_model.TabIndex = 3;
            this.Btn_model.Text = "Марка авто";
            this.Btn_model.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(993, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // YourCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 579);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Btn_model);
            this.Controls.Add(this.Btn_changeWheel);
            this.Controls.Add(this.Btn_refuel);
            this.Controls.Add(this.Btn_move);
            this.Name = "YourCar";
            this.Text = "Авто";
            this.Load += new System.EventHandler(this.Car_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button Btn_refuel;
        private System.Windows.Forms.Button Btn_changeWheel;
        private System.Windows.Forms.Button Btn_model;
        private System.Windows.Forms.Button button5;
    }
}

