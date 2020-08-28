package ControllerPackage;

import java.util.ArrayList;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;

import feecalculator.Manupulator;
import feecalculator.TransactionFormat;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class RequestMappingController {

	@Autowired
	Manupulator manupulator;
	@RequestMapping("/")
	public String he(ModelMap mp) {
		ArrayList<TransactionFormat> transactionList = manupulator.returnElements();
		mp.put("list", transactionList);
		return "outputfile";
	}

	@RequestMapping("/home")
	@ResponseBody
	public String home(){
		return "Home";
	}
}