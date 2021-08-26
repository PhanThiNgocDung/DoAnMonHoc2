package com.example.doandd_datdoan.Class;

import java.io.Serializable;

public class SuKienTaiKhoan_Class implements Serializable {
    String suKien;

    public SuKienTaiKhoan_Class(String suKien) {
        this.suKien = suKien;
    }

    public String getSuKien() {
        return suKien;
    }

    public void setSuKien(String suKien) {
        this.suKien = suKien;
    }
}
