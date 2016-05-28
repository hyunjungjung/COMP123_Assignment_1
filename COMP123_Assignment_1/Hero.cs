using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Joanne (Hyunjung) Jung
 * Student # : 300432364
 * Date Modified: May 27, 2016
 * Description: Hero class for Assignment 1
 * Version: 0.0.2 - Added private instance variables 
 *                  and Public properties to Hero Class.
 */
namespace COMP123_Assignment_1
{
    /**
    * This class defines a generic Hero
    * 
    * @class Hero
    * @field {int} _strength 
    * @field {int} _speed
    * @field {int} _health
    * @field {string} _name
    */
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // 1a
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // 1b
        /**
         * <summary>
         * This is a property for our _strength field
         * </summary>
         * @property {int} Strength
         */

        public int Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }
        /**
         * <summary>
         * This is a property for our _speed field
         * </summary>
         * @property {int} Speed
         */
        public int Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }
        /**
         * <summary>
         * This is a property for our _health field
         * </summary>
         * @property {int} Health
         */
        public int Health
        {
            get { return this._health; }
            set { this._health = value; }
        }
        /**
         * <summary>
         * This is a property for our _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }
}
