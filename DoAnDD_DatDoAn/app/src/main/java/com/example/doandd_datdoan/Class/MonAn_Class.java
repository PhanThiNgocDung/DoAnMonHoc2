package com.example.doandd_datdoan.Class;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;

import java.io.IOException;
import java.io.InputStream;
import java.io.Serializable;

public class MonAn_Class implements Serializable {
    String tenSP;
    String hinhSP;
    String danhGia;   
    String soCay;
    String gia;
    String maCH;
    String maMonAn;

    public String getMaMonAn() {
        return maMonAn;
    }

    public void setMaMonAn(String maMonAn) {
        this.maMonAn = maMonAn;
    }

    public MonAn_Class(String tenSP, String hinhSP, String danhGia, String soCay, String gia, String maCH, String maMonAn) {
        this.tenSP = tenSP;
        this.hinhSP = hinhSP;
        this.danhGia = danhGia;
        this.soCay = soCay;
        this.gia = gia;
        this.maCH = maCH;
        this.maMonAn = maMonAn;
    }

    public String getMaCH() {
        return maCH;
    }

    public void setMaCH(String maCH) {
        this.maCH = maCH;
    }

    public String getGia() {
        return gia;
    }

    public void setGia(String gia) {
        this.gia = gia;
    }

    public MonAn_Class(String tenSP, String hinhSP, String danhGia, String soCay, String gia) {
        this.tenSP = tenSP;
        this.hinhSP = hinhSP;
        this.danhGia = danhGia;
        this.soCay = soCay;
        this.gia = gia;
    }

    public MonAn_Class() {
    }
    public MonAn_Class(String tenSP, String hinhSP, String danhGia, String soCay) {
        this.tenSP = tenSP;
        this.hinhSP = hinhSP;
        this.danhGia = danhGia;
        this.soCay = soCay;
    }

    public String getTenSP() {
        return tenSP;
    }

    public void setTenSP(String tenSP) {
        this.tenSP = tenSP;
    }

    public String getHinhSP() {
        return hinhSP;
    }

    public void setHinhSP(String hinhSP) {
        this.hinhSP = hinhSP;
    }

    public String getDanhGia() {
        return danhGia;
    }

    public void setDanhGia(String danhGia) {
        this.danhGia = danhGia;
    }

    public String getSoCay() {
        return soCay;
    }

    public void setSoCay(String soCay) {
        this.soCay = soCay;
    }
    //Hình
    public static Bitmap convertStringToBitmapFromAccess(Context context, String
            filename){
        AssetManager assetManager = context.getAssets();
        try {
            InputStream is = assetManager.open(filename);
            Bitmap bitmap = BitmapFactory.decodeStream(is);
            return bitmap;
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }
    public void setImage_bit(Bitmap image_bit) {
        this.image_bit = image_bit;
    }
    Bitmap image_bit;
    public Bitmap getImage_bit() {
        return image_bit;
    }
}

