package com.sagban.feecalculator;

import java.util.ArrayList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;

import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class RequestMappingController {

	@Autowired
	Manupulator manupulator;
	@RequestMapping("/getfee")
	public String he(ModelMap mp) {
		ArrayList<TransactionFormat> transactionList = manupulator.returnElements();
		mp.put("list", transactionList);
		return "outputfile";
	}

	@RequestMapping("/")
	@ResponseBody
	public String home(){
		return "Home";
	}
}