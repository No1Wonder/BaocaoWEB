using System;
using System.Collections.Generic;

namespace FinanceLibrary
{
    public class FinanceManager
    {
        // Input lưu số lượng nhập
        public Dictionary<string, int> Chi { get; private set; }
        public Dictionary<string, int> Thu { get; private set; }

        // Bảng giá Chi phí
        private Dictionary<string, int> BangGiaChi = new Dictionary<string, int>()
        {
            {"muoi", 80000},
            {"bot", 20000},
            {"my", 80000},
            {"gao", 120000},
            {"gas", 200000},
            {"nuoc", 10000},
            {"dien", 4000},
            {"duong", 40000},
            {"chanh", 40000},
            {"tra", 80000}
        };

        // Bảng giá Thu nhập
        private Dictionary<string, int> BangGiaThu = new Dictionary<string, int>()
        {
            {"com", 25000},
            {"trachanh", 20000},
            {"mysuat", 15000}
        };

        public FinanceManager()
        {
            Chi = new Dictionary<string, int>();
            Thu = new Dictionary<string, int>();
        }

        // Thêm chi phí
        public void AddChi(string ten, int soLuong)
        {
            if (Chi.ContainsKey(ten))
                Chi[ten] += soLuong;
            else
                Chi[ten] = soLuong;
        }

        // Thêm thu nhập
        public void AddThu(string ten, int soLuong)
        {
            if (Thu.ContainsKey(ten))
                Thu[ten] += soLuong;
            else
                Thu[ten] = soLuong;
        }

        // Tính tổng chi phí
        public int TinhTongChi()
        {
            int tong = 0;
            foreach (var item in Chi)
            {
                if (BangGiaChi.ContainsKey(item.Key))
                    tong += BangGiaChi[item.Key] * item.Value;
            }
            return tong;
        }

        // Tính tổng thu nhập
        public int TinhTongThu()
        {
            int tong = 0;
            foreach (var item in Thu)
            {
                if (BangGiaThu.ContainsKey(item.Key))
                    tong += BangGiaThu[item.Key] * item.Value;
            }
            return tong;
        }

        // Lợi nhuận
        public int TinhLoiNhuan()
        {
            return TinhTongThu() - TinhTongChi();
        }
    }
}
