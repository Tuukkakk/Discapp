using System;
using System.Collections.Generic;
using Discapp;

namespace Discapp {
    public class CourseData {
        public static List<Course> GetCourses() {
            return new List<Course>
            {
                new Course
                {
                    Name = "Utran frisbeegolfrata",
                    Par = 60,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 153, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-1_w.jpg" },
                        new Hole { Number = 2, Meters = 167, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-2_w.jpg" },
                        new Hole { Number = 3, Meters = 153, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-3_w.jpg"},
                        new Hole { Number = 4, Meters = 111, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-4_2.jpg"},
                        new Hole { Number = 5, Meters = 87, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-5_w.jpg"},
                        new Hole { Number = 6, Meters = 96, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-6_w.jpg"},
                        new Hole { Number = 7, Meters = 148, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-7_w.jpg"},
                        new Hole { Number = 8, Meters = 82, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2014/05/vayla-8_w.jpg"},
                        new Hole { Number = 9, Meters = 91, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2014/05/vayla-9_w.jpg"},
                        new Hole { Number = 10, Meters = 88, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/utra_vayla_10_2022.jpg"},
                        new Hole { Number = 11, Meters = 66, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/utra_vayla_11_2022.jpg"},
                        new Hole { Number = 12, Meters = 79, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2014/05/vayla-12_w.jpg"},
                        new Hole { Number = 13, Meters = 72, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-13_w.jpg"},
                        new Hole { Number = 14, Meters = 121, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-14_w.jpg"},
                        new Hole { Number = 15, Meters = 77, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2015/07/vayla-15_w.jpg"},
                        new Hole { Number = 16, Meters = 85, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2014/05/vayla-16_w.jpg"},
                        new Hole { Number = 17, Meters = 80, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-17_w.jpg"},
                        new Hole { Number = 18, Meters = 146, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2012/05/vayla-18_w.jpg"},

                    }
                },
                new Course
                {
                    Name = "Lykynlampi-blue",
                    Par = 69,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 101, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_01_web-724x1024.jpg" },
                        new Hole { Number = 2, Meters = 95, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_02_web-724x1024.jpg" },
                        new Hole { Number = 3, Meters = 132, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_03_web-724x1024.jpg"},
                        new Hole { Number = 4, Meters = 104, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_04_web-724x1024.jpg"},
                        new Hole { Number = 5, Meters = 132, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_05_web-724x1024.jpg"},
                        new Hole { Number = 6, Meters = 120, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_06S_web-724x1024.jpg"},
                        new Hole { Number = 7, Meters = 50, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_07S_web-724x1024.jpg"},
                        new Hole { Number = 8, Meters = 79, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_08_web-724x1024.jpg"},
                        new Hole { Number = 9, Meters = 205, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_09_web-724x1024.jpg"},
                        new Hole { Number = 10, Meters = 93, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_10_web-724x1024.jpg"},
                        new Hole { Number = 11, Meters = 187, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_11S_web-724x1024.jpg"},
                        new Hole { Number = 12, Meters = 156, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_12_web-724x1024.jpg"},
                        new Hole { Number = 13, Meters = 128, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_13S_web-724x1024.jpg"},
                        new Hole { Number = 14, Meters = 82, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_14_web-724x1024.jpg"},
                        new Hole { Number = 15, Meters = 83, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_15S_web-724x1024.jpg"},
                        new Hole { Number = 16, Meters = 323, Par = 5, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_16_web-724x1024.jpg"},
                        new Hole { Number = 17, Meters = 77, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_17S_web-724x1024.jpg"},
                        new Hole { Number = 18, Meters = 217, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_18_web-724x1024.jpg"},
                        new Hole { Number = 19, Meters = 178, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_19S_web-724x1024.jpg"},
                        new Hole { Number = 20, Meters = 92, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_20_web-724x1024.jpg"},
                    }
                },
                new Course
                {
                    Name = "Lykynlampi-Diamond",
                    Par = 64,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 101, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_01_web-724x1024.jpg"},
                        new Hole { Number = 2, Meters = 150, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_02_web-724x1024.jpg"},
                        new Hole { Number = 3, Meters = 132, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_03_web-724x1024.jpg"},
                        new Hole { Number = 4, Meters = 104, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_04_web-724x1024.jpg"},
                        new Hole { Number = 5, Meters = 132, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_05_web-724x1024.jpg"},
                        new Hole { Number = 6, Meters = 180, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_08_web-724x1024.jpg"},
                        new Hole { Number = 7, Meters = 205, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_09_web-724x1024.jpg"},
                        new Hole { Number = 8, Meters = 93, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_10_web-724x1024.jpg"},
                        new Hole { Number = 9, Meters = 187, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_11S_web-724x1024.jpg"},
                        new Hole { Number = 10, Meters = 156, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_12_web-724x1024.jpg"},
                        new Hole { Number = 11, Meters = 113, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_13S_web-724x1024.jpg"},
                        new Hole { Number = 12, Meters = 82, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_14_web-724x1024.jpg"},
                        new Hole { Number = 13, Meters = 83, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_15S_web-724x1024.jpg"},
                        new Hole { Number = 14, Meters = 323, Par = 5, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_16_web-724x1024.jpg"},
                        new Hole { Number = 15, Meters = 77, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_17S_web-724x1024.jpg"},
                        new Hole { Number = 16, Meters = 217, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_18_web-724x1024.jpg"},
                        new Hole { Number = 17, Meters = 178, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2024/05/Lykynlampi_vaylaopaste_2024_19_web-724x1024.jpg"},
                        new Hole { Number = 18, Meters = 92, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_20_web-724x1024.jpg"},

                    }
                },
                new Course
                {
                    Name = "Lykynlampi-Gold",
                    Par = 64,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 123, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_01_web-724x1024.jpg"},
                        new Hole { Number = 2, Meters = 150, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_02_web-724x1024.jpg"},
                        new Hole { Number = 3, Meters = 142, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_03_web-724x1024.jpg"},
                        new Hole { Number = 4, Meters = 128, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_04_web-724x1024.jpg"},
                        new Hole { Number = 5, Meters = 141, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_05_web-724x1024.jpg"},
                        new Hole { Number = 6, Meters = 180, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_08_web-724x1024.jpg"},
                        new Hole { Number = 7, Meters = 230, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_09_web-724x1024.jpg"},
                        new Hole { Number = 8, Meters = 115, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_10_web-724x1024.jpg"},
                        new Hole { Number = 9, Meters = 187, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_11S_web-724x1024.jpg"},
                        new Hole { Number = 10, Meters = 185, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_12_web-724x1024.jpg"},
                        new Hole { Number = 11, Meters = 128, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_13S_web-724x1024.jpg"},
                        new Hole { Number = 12, Meters = 109, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_14_web-724x1024.jpg"},
                        new Hole { Number = 13, Meters = 83, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_15S_web-724x1024.jpg"},
                        new Hole { Number = 14, Meters = 376, Par = 5, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_16_web-724x1024.jpg"},
                        new Hole { Number = 15, Meters = 77, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_17S_web-724x1024.jpg"},
                        new Hole { Number = 16, Meters = 249, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_18_web-724x1024.jpg"},
                        new Hole { Number = 17, Meters = 235, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2024/05/Lykynlampi_vaylaopaste_2024_19_web-724x1024.jpg"},
                        new Hole { Number = 18, Meters = 121, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2023/05/Lykynlampi_vaylaopaste_2023_20_web-724x1024.jpg"},
                    }
                },
                new Course
                {
                    Name = "Kontiorannan Frisbeegolfrata",
                    Par = 69,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 160, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_01_w.jpg"},
                        new Hole { Number = 2, Meters = 217, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_02_w.jpg"},
                        new Hole { Number = 3, Meters = 107, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-03.jpg",},
                        new Hole { Number = 4, Meters = 99, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_04_w.jpg"},
                        new Hole { Number = 5, Meters = 210, Par = 5, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_05_w.jpg"},
                        new Hole { Number = 6, Meters = 171, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_06_w.jpg"},
                        new Hole { Number = 7, Meters = 92, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-07.jpg"},
                        new Hole { Number = 8, Meters = 76, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-08.jpg"},
                        new Hole { Number = 9, Meters = 88, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-09.jpg"},
                        new Hole { Number = 10, Meters = 60, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-10.jpg"},
                        new Hole { Number = 11, Meters = 155, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_11_w.jpg"},
                        new Hole { Number = 12, Meters = 114, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_12_w.jpg"},
                        new Hole { Number = 13, Meters = 104, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_13_w.jpg"},
                        new Hole { Number = 14, Meters = 221, Par = 5, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-14.jpg"},
                        new Hole { Number = 15, Meters = 107, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_15_w.jpg"},
                        new Hole { Number = 16, Meters = 112, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_16_w.jpg"},
                        new Hole { Number = 17, Meters = 170, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2016/10/kontioranta-frisbeegolfrata-17.jpg"},
                        new Hole { Number = 18, Meters = 88, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_18_w.jpg"},
                        new Hole { Number = 19, Meters = 160, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_19_w.jpg"},
                        new Hole { Number = 20, Meters = 108, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2020/05/2020_kontioranta_20_w.jpg"},

                    }
                },
                new Course
                {
                    Name = "Paiholan Frisbeegolfrata",
                    Par = 54,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 83, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-01-min-725x1024.jpg"},
                        new Hole { Number = 2, Meters = 67, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-02-min-725x1024.jpg"},
                        new Hole { Number = 3, Meters = 70, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-03-min-725x1024.jpg"},
                        new Hole { Number = 4, Meters = 60, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-04-min-725x1024.jpg"},
                        new Hole { Number = 5, Meters = 67, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-05-min-725x1024.jpg"},
                        new Hole { Number = 6, Meters = 59, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-06-min-725x1024.jpg"},
                        new Hole { Number = 7, Meters = 75, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-07-min-725x1024.jpg"},
                        new Hole { Number = 8, Meters = 61, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-08-min-725x1024.jpg"},
                        new Hole { Number = 9, Meters = 140, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-09-min-725x1024.jpg"},
                        new Hole { Number = 10, Meters = 155, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-10-min-725x1024.jpg"},
                        new Hole { Number = 11, Meters = 75, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-11-min-725x1024.jpg"},
                        new Hole { Number = 12, Meters = 110, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-12-min-725x1024.jpg"},
                        new Hole { Number = 13, Meters = 110, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-13-min-725x1024.jpg"},
                        new Hole { Number = 14, Meters = 60, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-14-min-725x1024.jpg"},
                        new Hole { Number = 15, Meters = 106, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-15-min-725x1024.jpg"},
                        new Hole { Number = 16, Meters = 86, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-16-min-725x1024.jpg"},
                        new Hole { Number = 17, Meters = 85, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-17-min-725x1024.jpg"},
                        new Hole { Number = 18, Meters = 80, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/04/paihola-18-min-725x1024.jpg"},

                    }
                },
                new Course
                {
                    Name = "Liperin Frisbeegolfrata",
                    Par = 54,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 65, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_01-724x1024.jpg"},
                        new Hole { Number = 2, Meters = 60, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_02-724x1024.jpg"},
                        new Hole { Number = 3, Meters = 77, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_03-724x1024.jpg"},
                        new Hole { Number = 4, Meters = 64, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_04-724x1024.jpg"},
                        new Hole { Number = 5, Meters = 58, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_05-724x1024.jpg"},
                        new Hole { Number = 6, Meters = 140, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_06-724x1024.jpg"},
                        new Hole { Number = 7, Meters = 62, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_07-724x1024.jpg"},
                        new Hole { Number = 8, Meters = 74, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_08-724x1024.jpg"},
                        new Hole { Number = 9, Meters = 110, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_09-724x1024.jpg"},
                        new Hole { Number = 10, Meters = 55, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_10-724x1024.jpg"},
                        new Hole { Number = 11, Meters = 75, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_11-724x1024.jpg"},
                        new Hole { Number = 12, Meters = 100, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_12-724x1024.jpg"},
                        new Hole { Number = 13, Meters = 78, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_13-724x1024.jpg"},
                        new Hole { Number = 14, Meters = 78, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_14-724x1024.jpg"},
                        new Hole { Number = 15, Meters = 160, Par = 4, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_15-724x1024.jpg"},
                        new Hole { Number = 16, Meters = 75, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_16-724x1024.jpg"},
                        new Hole { Number = 17, Meters = 80, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_17-724x1024.jpg"},
                        new Hole { Number = 18, Meters = 68, Par = 3, ImgLink = "https://www.joenliitokiekko.com/wp-content/uploads/2022/07/liperi_vayla_18-724x1024.jpg"},

                    }
                },
                new Course
                {
                    Name = "Outokummun Frisbeegolfrata",
                    Par = 54,
                    Holes = new List<Hole>
                    {
                        new Hole { Number = 1, Meters = 90, Par = 3, ImgLink = ""},
                        new Hole { Number = 2, Meters = 102, Par = 3, ImgLink = ""},
                        new Hole { Number = 3, Meters = 78, Par = 3, ImgLink = ""},
                        new Hole { Number = 4, Meters = 43, Par = 3, ImgLink = ""},
                        new Hole { Number = 5, Meters = 74, Par = 3, ImgLink = ""},
                        new Hole { Number = 6, Meters = 127, Par = 4, ImgLink = ""},
                        new Hole { Number = 7, Meters = 100, Par = 3, ImgLink = ""},
                        new Hole { Number = 8, Meters = 157, Par = 4, ImgLink = ""},
                        new Hole { Number = 9, Meters = 140, Par = 4, ImgLink = ""},
                        new Hole { Number = 10, Meters = 66, Par = 3, ImgLink = ""},
                        new Hole { Number = 11, Meters = 150, Par = 4, ImgLink = ""},
                        new Hole { Number = 12, Meters = 60, Par = 3, ImgLink = ""},
                        new Hole { Number = 13, Meters = 81, Par = 3, ImgLink = ""},
                        new Hole { Number = 14, Meters = 89, Par = 3, ImgLink = ""},
                        new Hole { Number = 15, Meters = 141, Par = 4, ImgLink = ""},
                        new Hole { Number = 16, Meters = 60, Par = 3, ImgLink = ""},
                        new Hole { Number = 17, Meters = 86, Par = 3, ImgLink = ""},
                        new Hole { Number = 18, Meters = 58, Par = 3, ImgLink = ""},

                    }
                },

            };
        }
    }

    public class Course {
        public string Name { get; set; }
        public int Par { get; set; }
        public List<Hole> Holes { get; set; }

        public Course() {
            Holes = new List<Hole>();
        }
    }

    public class Hole {
        public int Number { get; set; }
        public int Meters { get; set; }
        public int Par { get; set; }
        public string ImgLink { get; set; }
    }
   
}
