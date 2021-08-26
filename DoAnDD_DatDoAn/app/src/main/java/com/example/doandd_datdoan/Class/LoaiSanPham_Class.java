package com.example.doandd_datdoan.Class;

import androidx.annotation.NonNull;

import java.io.Serializable;

public class LoaiSanPham_Class implements Serializable {
   String tenLoaiSP, hinhAnhLoai, maLoaiM;

    public String getMaLoaiM() {
        return maLoaiM;
    }

    public LoaiSanPham_Class(String tenLoaiSP, String hinhAnhLoai, String maLoaiM) {
        this.tenLoaiSP = tenLoaiSP;
        this.hinhAnhLoai = hinhAnhLoai;
        this.maLoaiM = maLoaiM;
    }

    public void setMaLoaiM(String maLoaiM) {
        this.maLoaiM = maLoaiM;
    }

    public String getTenLoaiSP() {
        return tenLoaiSP;
    }

    public void setTenLoaiSP(String tenLoaiSP) {
        this.tenLoaiSP = tenLoaiSP;
    }

    public String getHinhAnhLoai() {
        return hinhAnhLoai;
    }

    public void setHinhAnhLoai(String hinhAnhLoai) {
        this.hinhAnhLoai = hinhAnhLoai;
    }

    public LoaiSanPham_Class() {
    }

}
