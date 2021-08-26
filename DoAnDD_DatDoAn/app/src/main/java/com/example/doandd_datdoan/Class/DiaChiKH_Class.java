package com.example.doandd_datdoan.Class;

import java.io.Serializable;

public class DiaChiKH_Class  implements Serializable {
    String tenDiaChi, soCayCMinh, diachiCT;

    public DiaChiKH_Class(String tenDiaChi, String soCayCMinh, String diachiCT) {
        this.tenDiaChi = tenDiaChi;
        this.soCayCMinh = soCayCMinh;
        this.diachiCT = diachiCT;
    }

    public String getTenDiaChi() {
        return tenDiaChi;
    }

    public void setTenDiaChi(String tenDiaChi) {
        this.tenDiaChi = tenDiaChi;
    }

    public String getSoCayCMinh() {
        return soCayCMinh;
    }

    public void setSoCayCMinh(String soCayCMinh) {
        this.soCayCMinh = soCayCMinh;
    }

    public String getDiachiCT() {
        return diachiCT;
    }

    public void setDiachiCT(String diachiCT) {
        this.diachiCT = diachiCT;
    }
}
