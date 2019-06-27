namespace UsGov

module Concern =

    (*
         Departments of Agriculture, Commerce, Defense, Education, Energy, Health and Human Services (HHS),
         Homeland Security, Housing and Urban Development (HUD), Interior, Justice, Labor, State, Transportation,
         Treasury and Veteran's Affairs (VA)

         All actors of the government will be concerning themselves with these topics
    
    *)

    type agency =
        {
            Name: string
            Budget: decimal
        }


    type department = 
        Agriculture of agency
        | Commerce of agency
        | Defense of agency
        | Education of agency
        | Energy of agency
        | HHS of agency
        | HomelandSecurity of agency
        | HUD of agency
        | Interior of agency
        | Justice of agency
        | Labor of agency
        | State of agency
        | Transportation of agency
        | Treasury of agency
        | VA of agency
        | Wellness of agency