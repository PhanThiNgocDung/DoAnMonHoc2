package com.example.doandd_datdoan.Class;

import java.io.Serializable;

public class KhuyenMai_Class implements Serializable {
    String HinhAnhKM, TenKM, HSDKM, CTKhuyenMai, MaKM;

    public String getCTKhuyenMai() {
        return CTKhuyenMai;
    }

    public void setCTKhuyenMai(String CTKhuyenMai) {
        this.CTKhuyenMai = CTKhuyenMai;
    }

    public KhuyenMai_Class(String tenKM, String HSDKM, String CTKhuyenMai, String maKM) {
        TenKM = tenKM;
        this.HSDKM = HSDKM;
        this.CTKhuyenMai = CTKhuyenMai;
        MaKM = maKM;
    }

    public String getMaKM() {
        return MaKM;
    }

    public void setMaKM(String maKM) {
        MaKM = maKM;
    }

    public KhuyenMai_Class(String hinhAnhKM, String tenKM, String HSDKM) {
        this.HinhAnhKM = hinhAnhKM;
        this.TenKM = tenKM;
        this.HSDKM = HSDKM;
    }

    public String getHinhAnhKM() {
        return HinhAnhKM;
    }

    public void setHinhAnhKM(String hinhAnhKM) {
        HinhAnhKM = hinhAnhKM;
    }

    public String getTenKM() {
        return TenKM;
    }

    public void setTenKM(String tenKM) {
        TenKM = tenKM;
    }

    public String getHSDKM() {
        return HSDKM;
    }

    public void setHSDKM(String HSDKM) {
        this.HSDKM = HSDKM;
    }
}
