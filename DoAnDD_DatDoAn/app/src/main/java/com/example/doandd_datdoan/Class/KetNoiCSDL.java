package com.example.doandd_datdoan.Class;

import android.annotation.SuppressLint;
import android.os.StrictMode;
import android.util.Log;

import java.sql.Connection;
import java.sql.DriverManager;

public class KetNoiCSDL {
    Connection con;
    String usename, pass, ip, port, database;
    @SuppressLint("NewApi")
    public Connection KetNoiCSDL()
    {
        ip = "192.168.1.66";
        database="QL_DatDoAn";
        usename="dung";
        pass="sa2012";
        port="1433";
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        Connection connection = null;
        String connectionURL = null;
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver");
            connectionURL= "jdbc:jtds:sqlserver://"+ ip + ":"+ port+";"+ "databasename="+ database+";user="+usename+";password="+pass+";";
            connection= DriverManager.getConnection(connectionURL);
        }catch (Exception ex)
        {
            Log.e("Error", ex.getMessage());
        }
        return connection;
    }
}
