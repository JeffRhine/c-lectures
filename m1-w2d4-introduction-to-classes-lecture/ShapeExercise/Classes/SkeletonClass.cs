﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace Definition
// Uppercase and aligned with a module or general purpose it provides
// Seperated by Periods like TechElevator.Classes
namespace ProjectNamespace
{
    // Class declaration
    // Naming Convention: Singular, PascalCase
    public class SkeletonClass
    {

        // Field aka class variable
        //  - can only be referenced within the class
        //  - follows camelCase naming convention
        private string classVariable;

        ///////////////
        // PROPERTIES
        ///////////////
        // Notes:
        //  - Represent state or characteristics
        //  - Expose the 'private' variables through "getters" and "setters"
        //  - Follow PascalCaseNaming
        //  - Usually have the same name as the classVariable that they "protect"
        public string ClassVariable //<-- notice its named like the private variable up above
        {
            // Indicates that we can get the value of a property
            get
            {
                return this.classVariable;
            }
            // Indicates that we can set the value of a property
            set
            {
                this.classVariable = value; //<-- a reserved keyword indicating the value we assign to classVariable
            }
        }


        ///////////////
        // CONSTRUCTORS
        ///////////////
        // Default Constructor (no arguments)
        // Notes: 
        //  - Must match class name
        //  - Does not return anything
        //  - Also called the empty constructor
        public SkeletonClass()
        {
        }

        // Constructor
        //  - Must match class name
        //  - Still does not return anything
        //  - Must be different by taking different parameters        
        public SkeletonClass(string requiredVariableValue)
        {
            this.classVariable = requiredVariableValue;
        }


        ///////////////
        // METHODS
        ///////////////
        // Public Method
        //  - methods are named with verbs (i.e. GetSomething, CalculateSomething, DoSomething, AddSomething)
        //  - all methods have a return statement that ends it
        //  - It must return whatever type is defined in the method signature
        //  - void requires us just to return; (it means nothing)
        //  - methods control access to class variables - "Fields" 
        public void MethodDoSomething()
        {
            return;
        }

        
        // Public Method 2
        //  - additional public method
        public int MethodDoSomethingElse()
        {
            return 0;
        }

    }
}
