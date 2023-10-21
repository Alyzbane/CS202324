package com.example.quiz;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends Activity {

	Button b_clear, b_close, b_msg;
	RadioGroup rg_sex;
	EditText text;
	String ans = "",
		   gender = "";
	
    @Override
    protected void onCreate(Bundle savedInstanceState) 
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        text = (EditText) findViewById(R.id.edit_text);
        
        b_clear = (Button) findViewById(R.id.btn_clear);
        b_close = (Button) findViewById(R.id.btn_close);
        b_msg = (Button) findViewById(R.id.btn_display);
        
      
        addMainListenerButton();
        
    } // end of onCreate void
    
    private void buttonMessageListener()
    {
    	 b_msg.setOnClickListener(new View.OnClickListener() 
         {
 			@Override
 			public void onClick(View arg0) 
 			{
 				
 				rg_sex = getSexChoice();
 				
 				ans = ans + "Surname: " + text.getText().toString() + "\n";
 				
 				RadioButton gd = (RadioButton) findViewById(rg_sex.getCheckedRadioButtonId());
 				ans = ans + "Gender: " + gd.getText().toString() + "\n";
 				Toast.makeText(getApplicationContext(), ans, Toast.LENGTH_SHORT).show();
 				ans = "";
 			}
 			
 		  }); // end of b_msg actionlistener
    }
    
    private void buttonClearListener()
    {
    	b_clear.setOnClickListener(new View.OnClickListener() 
  	  {
			
			@Override
			public void onClick(View arg0) 
			{
				text = (EditText) findViewById(R.id.edit_text);
				text.setText("");
				
				rg_sex = getSexChoice();
				if(rg_sex.getCheckedRadioButtonId() != -1)  rg_sex.clearCheck();
					
			}
			
  	  }); // end of b_clear actionlistner
    }
    
    private void buttonCloseListener()
    {

  	  b_close.setOnClickListener(new View.OnClickListener()
  	  {
			
			@Override
			public void onClick(View arg0) 
			{
				
				
			}
	  });
    }
    
    private void addMainListenerButton()
    {
    	  
    	buttonCloseListener();
    	buttonClearListener();
    	buttonMessageListener();
 
    	  
    } // end of displayListenerButton
    
    private RadioGroup getSexChoice()
    {
    	return (RadioGroup) findViewById(R.id.rg_gender);
    }
    
    
    
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }
    
}
