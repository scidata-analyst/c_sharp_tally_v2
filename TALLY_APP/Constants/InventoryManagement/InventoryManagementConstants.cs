using System;

namespace TALLY_APP.Constants.InventoryManagement
{
    /**
     * @class InventoryManagementConstants
     * @description Contains all constant values for InventoryManagement module.
     *              Used to avoid magic strings across application.
     */
    public static class InventoryManagementConstants
    {

        /**
         * @constant StockItem_TABLE
         * @description Database table name for StockItem entity
         */
        public const string StockItem_TABLE = "stock_item";

        /**
         * @constant StockItem_ENTITY
         * @description Entity name reference for StockItem
         */
        public const string StockItem_ENTITY = "StockItem";

        /**
         * @constant StockGroup_TABLE
         * @description Database table name for StockGroup entity
         */
        public const string StockGroup_TABLE = "stock_group";

        /**
         * @constant StockGroup_ENTITY
         * @description Entity name reference for StockGroup
         */
        public const string StockGroup_ENTITY = "StockGroup";

        /**
         * @constant BatchRegister_TABLE
         * @description Database table name for BatchRegister entity
         */
        public const string BatchRegister_TABLE = "batch_register";

        /**
         * @constant BatchRegister_ENTITY
         * @description Entity name reference for BatchRegister
         */
        public const string BatchRegister_ENTITY = "BatchRegister";

        /**
         * @constant StockMovement_TABLE
         * @description Database table name for StockMovement entity
         */
        public const string StockMovement_TABLE = "stock_movement";

        /**
         * @constant StockMovement_ENTITY
         * @description Entity name reference for StockMovement
         */
        public const string StockMovement_ENTITY = "StockMovement";

        /**
         * @constant Godown_TABLE
         * @description Database table name for Godown entity
         */
        public const string Godown_TABLE = "godown";

        /**
         * @constant Godown_ENTITY
         * @description Entity name reference for Godown
         */
        public const string Godown_ENTITY = "Godown";

    }
}
