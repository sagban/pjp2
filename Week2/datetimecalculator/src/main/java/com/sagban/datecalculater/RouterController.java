package com.sagban.datecalculater;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

@Controller
public class RouterController {

    @Autowired
    DateService dateService;

    @RequestMapping("/")
    public String  home(
            Model model,
            @RequestParam(value="date1", required = false) String date1,
            @RequestParam(value="date2", required = false) String date2
    ) throws ParseException {

        if(isNullOrEmpty(date1) || isNullOrEmpty(date2)){
            model.addAttribute("message", "Select both the dates to continue");
        }
        else {
            model.addAttribute("date1", date1);
            model.addAttribute("date2", date2);
            int days = dateService.calculateDays(stringToDate(date1), stringToDate(date2));
            model.addAttribute("days", days);
        }
        return "home";
    }
    static private boolean isNullOrEmpty(String str) {
        return str == null || str.isEmpty();
    }
    static private Date stringToDate(String date) throws ParseException {
        DateFormat format = new SimpleDateFormat("MM/dd/yyyy");
        return format.parse(date);
    }
}
