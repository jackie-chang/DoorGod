using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DoorGodWeb.Models
{
    public static class DoorGodConst
    {
        //卡片狀態
        public const string 卡片啟用 = "4001";
        public const string 卡片遺失 = "4002";
        public const string 卡片損壞 = "4003";
        public const string 卡片退卡 = "4004";
        public const string 卡片停用 = "4005";

        //員工身分
        public const string 高階主管 = "高階主管";
        public const string 一般人員 = "一般人員";
        public const string 管理人員 = "管理人員";

        //停車證類型
        public const string 汽車停車證 = "1";
        public const string 機車停車證 = "2";

        /// <summary>
        /// 取得卡片狀態的集合
        /// </summary>
        /// <returns></returns>
        public static List<SelectListItem> GetCardStateListItem()
        {
            return new List<SelectListItem> {
                new SelectListItem() {Value=卡片啟用,Text= "卡片啟用" },
                new SelectListItem() {Value=卡片遺失,Text= "卡片遺失" },
                new SelectListItem() {Value=卡片損壞,Text= "卡片損壞" },
                new SelectListItem() {Value=卡片退卡,Text= "卡片退卡" },
                new SelectListItem() {Value=卡片停用,Text= "卡片停用" },
            };
        }
        /// <summary>
        /// 取得UserName(跟WebService 驗證的使用者)
        /// </summary>
        /// <returns></returns>
        public static string GetUserName()
        {
            return "CC_Dev";
        }

        /// <summary>
        /// 取得員工身分的集合
        /// </summary>
        /// <returns></returns>
        public static List<SelectListItem> GetEmpRoleListItem()
        {
            return new List<SelectListItem> {
                new SelectListItem() {Value=高階主管,Text= "高階主管" },
                new SelectListItem() {Value=一般人員,Text= "一般人員" },
                new SelectListItem() {Value=管理人員,Text= "管理人員" }
            };
        }

        public static List<SelectListItem> GetCarPassportType()
        {
            return new List<SelectListItem> {
                new SelectListItem() { Value=汽車停車證, Text="汽車停車證" },
                new SelectListItem() { Value=機車停車證, Text="機車停車證" }
            };
        }

        public static List<SelectListItem> GetEmpTempCardState()
        {
            return new List<SelectListItem> {
                new SelectListItem() { Value =卡片啟用, Text = "臨時卡啟用" },
                new SelectListItem() { Value =卡片停用, Text = "臨時卡歸還" }
            };

        }
    }
}