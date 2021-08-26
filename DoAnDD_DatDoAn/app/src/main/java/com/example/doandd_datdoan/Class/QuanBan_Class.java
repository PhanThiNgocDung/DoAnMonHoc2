package com.example.doandd_datdoan.Class;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;

import java.io.IOException;
import java.io.InputStream;
import java.io.Serializable;

public class QuanBan_Class implements Serializable {
    String tenQuan, thoiGianGao, soCay, soSao, hinhQN, maCH;

    public String getMaCH() {
        return maCH;
    }

    public QuanBan_Class(String tenQuan, String thoiGianGao, String soCay, String soSao, String hinhQN, String maCH) {
        this.tenQuan = tenQuan;
        this.thoiGianGao = thoiGianGao;
        this.soCay = soCay;
        this.soSao = soSao;
        this.hinhQN = hinhQN;
        this.maCH = maCH;
    }

    public void setMaCH(String maCH) {
        this.maCH = maCH;
    }

    public String getHinhQN() {
        return hinhQN;
    }

    public void setHinhQN(String hinhQN) {
        this.hinhQN = hinhQN;
    }

    public String getTenQuan() {
        return tenQuan;
    }

    public void setTenQuan(String tenQuan) {
        this.tenQuan = tenQuan;
    }

    public String getThoiGianGao() {
        return thoiGianGao;
    }

    public void setThoiGianGao(String thoiGianGao) {
        this.thoiGianGao = thoiGianGao;
    }

    public String getSoCay() {
        return soCay;
    }

    public void setSoCay(String soCay) {
        this.soCay = soCay;
    }

    public String getSoSao() {
        return soSao;
    }

    public void setSoSao(String soSao) {
        this.soSao = soSao;
    }


    public QuanBan_Class() {
    }
}
