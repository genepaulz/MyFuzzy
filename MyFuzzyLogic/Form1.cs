using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotFuzzy;

namespace MyFuzzyLogic
{
    public partial class Form1 : Form
    {
        FuzzyEngine fe0,fe1;
        MembershipFunctionCollection hottank, coldtank, thottank, tcoldtank, heat, cold;
        LinguisticVariable myhottank, mycoldtank, mythottank, mytcoldtank, myheat, mycold;
        FuzzyRuleCollection myhrules,mycrules;

        public void setMembers()
        {
            hottank = new MembershipFunctionCollection();
            hottank.Add(new MembershipFunction("S", 1.0, 100.0, 100.0, 200));
            hottank.Add(new MembershipFunction("M", 134, 234.0, 234.0, 334));
            hottank.Add(new MembershipFunction("L", 268.0, 384.0, 384.0, 500));
            myhottank = new LinguisticVariable("HOTTANK", hottank);

            coldtank = new MembershipFunctionCollection();
            coldtank.Add(new MembershipFunction("S", 1.0, 100.0, 100.0, 200));
            coldtank.Add(new MembershipFunction("M", 134, 234.0, 234.0, 334));
            coldtank.Add(new MembershipFunction("L", 268.0, 384.0, 384.0, 500));
            mycoldtank = new LinguisticVariable("COLDTANK", coldtank);

            thottank = new MembershipFunctionCollection();
            thottank.Add(new MembershipFunction("AMBIENT",26.0,34.0,34.0,60.0));
            thottank.Add(new MembershipFunction("WARM", 53.0, 66.5, 66.5, 80.0));
            thottank.Add(new MembershipFunction("HOT", 60.0, 66.5, 66.5, 94.0));
            mythottank = new LinguisticVariable("THOTTANK", thottank);

            tcoldtank = new MembershipFunctionCollection();
            tcoldtank.Add(new MembershipFunction("COLD", 10.0, 14.0, 14.0, 18.0));
            tcoldtank.Add(new MembershipFunction("WARM", 16.0, 18.0, 18.0, 20.0));
            tcoldtank.Add(new MembershipFunction("AMBIENT", 18.0, 22.0, 22.0, 26.0));
            mytcoldtank = new LinguisticVariable("TCOLDTANK", tcoldtank);

            heat = new MembershipFunctionCollection();
            heat.Add(new MembershipFunction("LOW",1.0,47.5,47.5,95.0));
            heat.Add(new MembershipFunction("MED",76.0,95.0,95.0,114.0));
            heat.Add(new MembershipFunction("HIGH",95,142.5,142.5,190));
            myheat = new LinguisticVariable("HEAT", heat);

            cold = new MembershipFunctionCollection();
            cold.Add(new MembershipFunction("LOW",1.0,16.5,16.5,33.0));
            cold.Add(new MembershipFunction("MED",27.0,33.0,33.0,59.0));
            cold.Add(new MembershipFunction("HIGH",33.0,49.5,49.5,65.0));
            mycold = new LinguisticVariable("COLD", cold);
        }

        public void setRules()
        {
            myhrules = new FuzzyRuleCollection();
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS AMBIENT) AND (HOTTANK IS S) THEN HEAT IS MED"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS AMBIENT) AND (HOTTANK IS M) THEN HEAT IS HIGH"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS AMBIENT) AND (HOTTANK IS L) THEN HEAT IS HIGH"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS WARM) AND (HOTTANK IS S) THEN HEAT IS LOW"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS WARM) AND (HOTTANK IS M) THEN HEAT IS MED"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS WARM) AND (HOTTANK IS L) THEN HEAT IS MED"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS HOT) AND (HOTTANK IS S) THEN HEAT IS LOW"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS HOT) AND (HOTTANK IS M) THEN HEAT IS LOW"));
            myhrules.Add(new FuzzyRule("IF (THOTTANK IS HOT) AND (HOTTANK IS L) THEN HEAT IS LOW"));

            mycrules = new FuzzyRuleCollection();
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS COLD) AND (COLDTANK IS S) THEN COLD IS LOW"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS COLD) AND (COLDTANK IS M) THEN COLD IS MED"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS COLD) AND (COLDTANK IS L) THEN COLD IS MED"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS WARM) AND (COLDTANK IS S) THEN COLD IS MED"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS WARM) AND (COLDTANK IS M) THEN COLD IS HIGH"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS WARM) AND (COLDTANK IS L) THEN COLD IS HIGH"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS AMBIENT) AND (COLDTANK IS S) THEN COLD IS HIGH"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS AMBIENT) AND (COLDTANK IS M) THEN COLD IS HIGH"));
            mycrules.Add(new FuzzyRule("IF (TCOLDTANK IS AMBIENT) AND (COLDTANK IS L) THEN COLD IS HIGH"));
        }

        public void setFuzzyEngine()
        {
            fe0 = new FuzzyEngine();
            fe0.LinguisticVariableCollection.Add(myhottank);
            fe0.LinguisticVariableCollection.Add(mythottank);
            fe0.LinguisticVariableCollection.Add(myheat);
            fe0.FuzzyRuleCollection = myhrules;

            fe1 = new FuzzyEngine();
            fe1.LinguisticVariableCollection.Add(mycoldtank);
            fe1.LinguisticVariableCollection.Add(mytcoldtank);
            fe1.LinguisticVariableCollection.Add(mycold);
            fe1.FuzzyRuleCollection = mycrules;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateFuzzyLogic_Click(object sender, EventArgs e)
        {
            setMembers();
            setRules();
        }

        private void DispenseHottrackBar_ValueChanged(object sender, EventArgs e)
        {
            myhottank.InputValue=(Convert.ToDouble(HotTanktextBox.Text));
            myhottank.Fuzzify("L");
            mythottank.InputValue = (Convert.ToDouble(THotTanktextBox.Text));
            mythottank.Fuzzify("HOT");
            setFuzzyEngine();
            fe0.Consequent = "HEAT";
            HeatertextBox.Text = "" + fe0.Defuzzify() + " Watts";
        }

    }
}
