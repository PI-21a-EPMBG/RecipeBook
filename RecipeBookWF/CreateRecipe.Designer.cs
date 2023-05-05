namespace RecipeBookWF
{
    partial class CreateRecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.recipeTextBox = new System.Windows.Forms.RichTextBox();
            this.ingridientsTextBox = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить рецепт";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(227, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Location = new System.Drawing.Point(94, 216);
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.Size = new System.Drawing.Size(227, 121);
            this.recipeTextBox.TabIndex = 2;
            this.recipeTextBox.Text = "";
            // 
            // ingridientsTextBox
            // 
            this.ingridientsTextBox.Location = new System.Drawing.Point(94, 104);
            this.ingridientsTextBox.Name = "ingridientsTextBox";
            this.ingridientsTextBox.Size = new System.Drawing.Size(227, 96);
            this.ingridientsTextBox.TabIndex = 3;
            this.ingridientsTextBox.Text = "";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(31, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ингридиенты:\r\n(писать через \r\nзапятую)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Рецепт";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(245, 363);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(164, 363);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 398);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ingridientsTextBox);
            this.Controls.Add(this.recipeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateRecipe";
            this.Text = "CreateRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox recipeTextBox;
        private System.Windows.Forms.RichTextBox ingridientsTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}