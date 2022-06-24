using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduAdminSys.connDB
{
    class CreateNo
    {
        private int rep = 0;
        static private int ed = 0;
        static private char ch = 'A';

        public string getSelectNo()
        {
            return GenerateCheckCode(8);
        }

        //随机产生指定长度的字母字符串(数字字母混和)
        public string GenerateCheckCode(int codeCount)
        {
            string str = string.Empty;
            long num2 = DateTime.Now.Ticks + this.rep;
            this.rep++;
            Random random = new Random(((int)(((ulong)num2) & 0xffffffffL)) | ((int)(num2 >> this.rep)));
            int sw = codeCount - 2;
            for (int i = 0; i < sw; i++)
            {
                char ch;
                int num = random.Next();
                if ((num % 2) == 0)
                {
                    ch = (char)(0x30 + ((ushort)(num % 10)));
                }
                else
                {
                    ch = (char)(0x41 + ((ushort)(num % 0x1a)));
                }
                str = str + ch.ToString();
            }
            ed = ed + 1;
            ch++;
            if (ed == 10) ed = 0;
            if (ch == '[') ch = 'A';
            str = str + ed.ToString();
            str = str + ch;
            return str;
        }
    }
}
