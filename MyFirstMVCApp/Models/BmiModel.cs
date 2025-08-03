using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCApp.Models
{
    public class FormModel
    {
        public float Height { get; set; } // 公分
        public float Weight { get; set; } // 公斤
        public int Age { get; set; } // 年齡
        public string Gender { get; set; } // 性別
        public double BMIResult { get; set; }
        public double BMRResult { get; set; }
        public string Category { get; set; }
        public bool IsSubmitted { get; set; } = false;
    }
}
