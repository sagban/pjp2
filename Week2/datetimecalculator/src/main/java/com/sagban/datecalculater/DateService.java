package com.sagban.datecalculater;

import org.springframework.stereotype.Controller;
import java.util.Date;

@Controller
public class DateService {
    public int calculateDays(Date d1, Date d2){
        return (int)( (d2.getTime() - d1.getTime()) / (1000 * 60 * 60 * 24));
    }
}
