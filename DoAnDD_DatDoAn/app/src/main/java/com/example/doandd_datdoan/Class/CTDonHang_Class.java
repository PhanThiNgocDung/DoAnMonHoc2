package com.example.doandd_datdoan.Class;

import java.io.Serializable;

public class CTDonHang_Class implements Serializable {
    String maMon, tenMon, GiaMon, stt, maCH;

    public String getStt() {
        return stt;
    }

    public String getMaCH() {
        return maCH;
    }

    public void setMaCH(String maCH) {
        this.maCH = maCH;
    }

    public void setStt(String stt) {
        this.stt = stt;
    }


    public CTDonHang_Class(String maMon, String tenMon, String giaMon, String stt, String maCH) {
        this.maMon = maMon;
        this.tenMon = tenMon;
        GiaMon = giaMon;
        this.stt = stt;
        this.maCH = maCH;
    }

    public String getMaMon() {
        return maMon;
    }

    public void setMaMon(String maMon) {
        this.maMon = maMon;
    }

    public String getTenMon() {
        return tenMon;
    }

    public void setTenMon(String tenMon) {
        this.tenMon = tenMon;
    }

    public String getGiaMon() {
        return GiaMon;
    }

    public void setGiaMon(String giaMon) {
        GiaMon = giaMon;
    }
}
