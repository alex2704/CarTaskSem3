namespace Task1Form
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
            this.Btn_showModel = new System.Windows.Forms.Button();
            this.Engine_box = new System.Windows.Forms.TextBox();
            this.Wheel_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Info_box = new System.Windows.Forms.TextBox();
            this.Model_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_move
            // 
            this.Btn_move.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_move.Location = new System.Drawing.Point(572, 33);
            this.Btn_move.Name = "Btn_move";
            this.Btn_move.Size = new System.Drawing.Size(210, 55);
            this.Btn_move.TabIndex = 0;
            this.Btn_move.Text = "Ехать";
            this.Btn_move.UseVisualStyleBackColor = true;
            this.Btn_move.Click += new System.EventHandler(this.Btn_move_Click);
            // 
            // Btn_refuel
            // 
            this.Btn_refuel.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refuel.Location = new System.Drawing.Point(572, 117);
            this.Btn_refuel.Name = "Btn_refuel";
            this.Btn_refuel.Size = new System.Drawing.Size(210, 55);
            this.Btn_refuel.TabIndex = 1;
            this.Btn_refuel.Text = "Заправиться";
            this.Btn_refuel.UseVisualStyleBackColor = true;
            this.Btn_refuel.Click += new System.EventHandler(this.Btn_refuel_Click);
            // 
            // Btn_changeWheel
            // 
            this.Btn_changeWheel.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_changeWheel.Location = new System.Drawing.Point(572, 189);
            this.Btn_changeWheel.Name = "Btn_changeWheel";
            this.Btn_changeWheel.Size = new System.Drawing.Size(210, 55);
            this.Btn_changeWheel.TabIndex = 2;
            this.Btn_changeWheel.Text = "Сменить колесо";
            this.Btn_changeWheel.UseVisualStyleBackColor = true;
            this.Btn_changeWheel.Click += new System.EventHandler(this.Btn_changeWheel_Click);
            // 
            // Btn_showModel
            // 
            this.Btn_showModel.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_showModel.Location = new System.Drawing.Point(572, 263);
            this.Btn_showModel.Name = "Btn_showModel";
            this.Btn_showModel.Size = new System.Drawing.Size(210, 55);
            this.Btn_showModel.TabIndex = 3;
            this.Btn_showModel.Text = "Узнать модель авто";
            this.Btn_showModel.UseVisualStyleBackColor = true;
            this.Btn_showModel.Click += new System.EventHandler(this.Btn_showModel_Click);
            // 
            // Engine_box
            // 
            this.Engine_box.Location = new System.Drawing.Point(263, 18);
            this.Engine_box.Name = "Engine_box";
            this.Engine_box.Size = new System.Drawing.Size(221, 22);
            this.Engine_box.TabIndex = 4;
            // 
            // Wheel_box
            // 
            this.Wheel_box.Location = new System.Drawing.Point(263, 79);
            this.Wheel_box.Name = "Wheel_box";
            this.Wheel_box.Size = new System.Drawing.Size(221, 22);
            this.Wheel_box.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Двигатель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Колеса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Доп информация";
            // 
            // Info_box
            // 
            this.Info_box.Location = new System.Drawing.Point(263, 134);
            this.Info_box.Name = "Info_box";
            this.Info_box.Size = new System.Drawing.Size(221, 22);
            this.Info_box.TabIndex = 9;
            // 
            // Model_box
            // 
            this.Model_box.Location = new System.Drawing.Point(572, 336);
            this.Model_box.Name = "Model_box";
            this.Model_box.Size = new System.Drawing.Size(210, 22);
            this.Model_box.TabIndex = 10;
            // 
            // YourCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(794, 517);
            this.Controls.Add(this.Model_box);
            this.Controls.Add(this.Info_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wheel_box);
            this.Controls.Add(this.Engine_box);
            this.Controls.Add(this.Btn_showModel);
            this.Controls.Add(this.Btn_changeWheel);
            this.Controls.Add(this.Btn_refuel);
            this.Controls.Add(this.Btn_move);
            this.Name = "YourCar";
            this.Text = "Машина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_move;
        private System.Windows.Forms.Button Btn_refuel;
        private System.Windows.Forms.Button Btn_changeWheel;
        private System.Windows.Forms.Button Btn_showModel;
        private System.Windows.Forms.TextBox Engine_box;
        private System.Windows.Forms.TextBox Wheel_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Info_box;
        private System.Windows.Forms.TextBox Model_box;
    }
}

