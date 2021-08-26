package com.example.doandd_datdoan.Class;

import java.io.Serializable;

public class DonHangCu_Class implements Serializable {
    String tinhTrang, thoiGian, tenQuan, diaChi, tongTien, hinhThucTT, tongMon;



    public DonHangCu_Class(String tinhTrang, String thoiGian, String tenQuan, String diaChi, String tongTien, String hinhThucTT, String tongMon) {
        this.tinhTrang = tinhTrang;
        this.thoiGian = thoiGian;
        this.tenQuan = tenQuan;
        this.diaChi = diaChi;
        this.tongTien = tongTien;
        this.hinhThucTT = hinhThucTT;
        this.tongMon = tongMon;
    }


    public String getTinhTrang() {
        return tinhTrang;
    }

    public void setTinhTrang(String tinhTrang) {
        this.tinhTrang = tinhTrang;
    }

    public String getThoiGian() {
        return thoiGian;
    }

    public void setThoiGian(String thoiGian) {
        this.thoiGian = thoiGian;
    }

    public String getTenQuan() {
        return tenQuan;
    }

    public void setTenQuan(String tenQuan) {
        this.tenQuan = tenQuan;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public String getTongTien() {
        return tongTien;
    }

    public void setTongTien(String tongTien) {
        this.tongTien = tongTien;
    }

    public String getHinhThucTT() {
        return hinhThucTT;
    }

    public void setHinhThucTT(String hinhThucTT) {
        this.hinhThucTT = hinhThucTT;
    }

    public String getTongMon() {
        return tongMon;
    }

    public void setTongMon(String tongMon) {
        this.tongMon = tongMon;
    }
}
