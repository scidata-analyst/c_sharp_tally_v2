using System;

namespace TALLY_APP.Constants.GSTTaxation
{
    /**
     * @class GSTTaxationConstants
     * @description Contains all constant values for GSTTaxation module.
     *              Used to avoid magic strings across application.
     */
    public static class GSTTaxationConstants
    {

        /**
         * @constant GSTEntry_TABLE
         * @description Database table name for GSTEntry entity
         */
        public const string GSTEntry_TABLE = "gst_entry";

        /**
         * @constant GSTEntry_ENTITY
         * @description Entity name reference for GSTEntry
         */
        public const string GSTEntry_ENTITY = "GSTEntry";

        /**
         * @constant VATServiceTax_TABLE
         * @description Database table name for VATServiceTax entity
         */
        public const string VATServiceTax_TABLE = "vat_service_tax";

        /**
         * @constant VATServiceTax_ENTITY
         * @description Entity name reference for VATServiceTax
         */
        public const string VATServiceTax_ENTITY = "VATServiceTax";

        /**
         * @constant GSTReturn_TABLE
         * @description Database table name for GSTReturn entity
         */
        public const string GSTReturn_TABLE = "gst_return";

        /**
         * @constant GSTReturn_ENTITY
         * @description Entity name reference for GSTReturn
         */
        public const string GSTReturn_ENTITY = "GSTReturn";

        /**
         * @constant TDSTCSEntry_TABLE
         * @description Database table name for TDSTCSEntry entity
         */
        public const string TDSTCSEntry_TABLE = "tds_tcs_entry";

        /**
         * @constant TDSTCSEntry_ENTITY
         * @description Entity name reference for TDSTCSEntry
         */
        public const string TDSTCSEntry_ENTITY = "TDSTCSEntry";

    }
}
