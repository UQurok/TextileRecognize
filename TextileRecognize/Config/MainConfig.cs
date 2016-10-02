using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config.TextileRecognizer
{
    static class MainConfig
    {
        public static void Initialize()
        {
            MinCountWarpThread = 3;
            MinCountWeftThread = 3;
            MaxImgHeight = 1000;
            MaxImgWidth = 1000;
        }

        #region Минимальное количество нитей на образце
        public static int MinCountWeftThread { get; set; } //Уточных нитей
        public static int MinCountWarpThread { get; set; } //Нитей основы
        #endregion

        #region Максимальные размеры картинки
        public static int MaxImgHeight { get; set; }
        public static int MaxImgWidth { get; set; }
        #endregion
    }
}
