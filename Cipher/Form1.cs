using System.Text;

namespace Cipher
{
    public partial class Form1 : Form
    {
        private char[,] matrix = new char[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text.ToUpper().Replace(" ", "");
            string plaintext = plainTextBox.Text.ToUpper().Replace(" ", "");
            string ciphertext = Encrypt(plaintext, key);
            cipherTextBox.Text = ciphertext;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text.ToUpper().Replace(" ", "");
            string ciphertext = cipherTextBox.Text.ToUpper().Replace(" ", "");
            string plaintext = Decrypt(ciphertext, key);
            plainTextBox.Text = plaintext;
        }

        private string Encrypt(string plaintext, string key)
        {
            GenerateMatrix(key);
            plaintext = plaintext.Replace('J', 'I'); // Замена J на I

            // Вставляем 'X' между соседними буквами
            StringBuilder modifiedPlaintext = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i++)
            {
                modifiedPlaintext.Append(plaintext[i]);
                if (i < plaintext.Length - 1 && plaintext[i] == plaintext[i + 1])
                {
                    modifiedPlaintext.Append('X');
                }
            }

            // Если длина исходного текста стала нечетной после вставки 'X', добавляем 'X' в конец
            if (modifiedPlaintext.Length % 2 != 0)
            {
                modifiedPlaintext.Append('X');
            }

            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < modifiedPlaintext.Length; i += 2)
            {
                char first = modifiedPlaintext[i];
                char second = modifiedPlaintext[i + 1];

                int[] firstPosition = FindPosition(first);
                int[] secondPosition = FindPosition(second);

                if (firstPosition != null && secondPosition != null)
                {
                    int row1 = firstPosition[0];
                    int col1 = firstPosition[1];
                    int row2 = secondPosition[0];
                    int col2 = secondPosition[1];

                    if (row1 == row2)
                    {
                        encryptedText.Append(matrix[row1, (col1 + 1) % 5]);
                        encryptedText.Append(matrix[row2, (col2 + 1) % 5]);
                    }
                    else if (col1 == col2)
                    {
                        encryptedText.Append(matrix[(row1 + 1) % 5, col1]);
                        encryptedText.Append(matrix[(row2 + 1) % 5, col2]);
                    }
                    else
                    {
                        encryptedText.Append(matrix[row1, col2]);
                        encryptedText.Append(matrix[row2, col1]);
                    }
                }
            }

            return encryptedText.ToString();
        }

        private string Decrypt(string ciphertext, string key)
        {
            GenerateMatrix(key);

            StringBuilder decryptedText = new StringBuilder();
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char first = ciphertext[i];
                char second = ciphertext[i + 1];

                int[] firstPosition = FindPosition(first);
                int[] secondPosition = FindPosition(second);

                int row1 = firstPosition[0];
                int col1 = firstPosition[1];
                int row2 = secondPosition[0];
                int col2 = secondPosition[1];

                if (row1 == row2)
                {
                    decryptedText.Append(matrix[row1, (col1 - 1 + 5) % 5]);
                    decryptedText.Append(matrix[row2, (col2 - 1 + 5) % 5]);
                }
                else if (col1 == col2)
                {
                    decryptedText.Append(matrix[(row1 - 1 + 5) % 5, col1]);
                    decryptedText.Append(matrix[(row2 - 1 + 5) % 5, col2]);
                }
                else
                {
                    decryptedText.Append(matrix[row1, col2]);
                    decryptedText.Append(matrix[row2, col1]);
                }
            }
            return decryptedText.ToString();
        }

        private void GenerateMatrix(string key)
        {
            key = key.ToUpper().Replace('J', 'I'); // Преобразование ключа в верхний регистр и замена J на I
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Алфавит без J
            key += alphabet; // Добавление алфавита к ключу

            HashSet<char> usedChars = new HashSet<char>(); // Хранение использованных символов
            int index = 0;

            // Заполнение матрицы построчно
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    char currentChar = key[index++];

                    // Пропуск использованных символов
                    while (usedChars.Contains(currentChar))
                    {
                        currentChar = key[index++];
                    }

                    matrix[row, col] = currentChar;
                    usedChars.Add(currentChar);
                }
            }
            StringBuilder mat = new StringBuilder();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    mat.Append(matrix[row, col]);
                    mat.Append(" ");
                }
                mat.Append("     ");
            }

            textBox1.Text = mat.ToString();
        }

        private int[] FindPosition(char letter)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (matrix[row, col] == letter)
                    {
                        return new int[] { row, col };
                    }
                }
            }
            return null;
        }
    }
}
