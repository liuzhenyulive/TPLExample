﻿using System;
using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using HeProject.Model;
using NPOI.SS.Util;

namespace HeProject
{
    public class WriteToExcel
    {
        private readonly ProcessContext _context;
        private readonly int _p1FirstRow;
        private readonly int _p2FirstRow;
        private ICellStyle _headerStyle;

        private ICellStyle _s2P1Style;
        private ICellStyle _s4P1Style;
        private ICellStyle _s6P1Style;
        private ICellStyle _s7P1Style;
        private ICellStyle _s8P1Style;
        private ICellStyle _s9P1Style;

        private ICellStyle _s2P2Style;
        private ICellStyle _s4P2Style;
        private ICellStyle _s6P2Style;
        private ICellStyle _s7P2Style;
        private ICellStyle _s8P2Style;
        private ICellStyle _s9P2Style;

        private ICellStyle _s2P3Style;
        private ICellStyle _s4P3Style;
        private ICellStyle _s6P3Style;
        private ICellStyle _s7P3Style;
        private ICellStyle _s8P3Style;
        private ICellStyle _s9P3Style;

        private ICellStyle _s2P4Style;
        private ICellStyle _s4P4Style;
        private ICellStyle _s6P4Style;
        private ICellStyle _s7P4Style;
        private ICellStyle _s8P4Style;
        private ICellStyle _s9P4Style;

        private ICellStyle _totalStyle;
        private ICellStyle _reStyle;
        private ICellStyle _lengStyle;
        private ICellStyle _reLengTotalStyle;
        private ICellStyle _wuJiaoStyle;
        private ICellStyle _sanJiaoStyle;
        private ICellStyle _yuanStyle;

        private ICellStyle _s1P6Style;
        private ICellStyle _s2P6Style;

        public WriteToExcel(ProcessContext context)
        {
            _p1FirstRow = 1;
            _p2FirstRow = _p1FirstRow + context.Capacity + 2;
            _context = context;
        }

        public void Write()
        {
            try
            {
                IWorkbook workbook = new XSSFWorkbook();
                _headerStyle = workbook.CreateCellStyle();

                #region SetStyle

                _s2P1Style = workbook.CreateCellStyle();
                _s4P1Style = workbook.CreateCellStyle();
                _s6P1Style = workbook.CreateCellStyle();
                _s7P1Style = workbook.CreateCellStyle();
                _s8P1Style = workbook.CreateCellStyle();
                _s9P1Style = workbook.CreateCellStyle();

                _s2P2Style = workbook.CreateCellStyle();
                _s4P2Style = workbook.CreateCellStyle();
                _s6P2Style = workbook.CreateCellStyle();
                _s7P2Style = workbook.CreateCellStyle();
                _s8P2Style = workbook.CreateCellStyle();
                _s9P2Style = workbook.CreateCellStyle();

                _s2P3Style = workbook.CreateCellStyle();
                _s4P3Style = workbook.CreateCellStyle();
                _s6P3Style = workbook.CreateCellStyle();
                _s7P3Style = workbook.CreateCellStyle();
                _s8P3Style = workbook.CreateCellStyle();
                _s9P3Style = workbook.CreateCellStyle();

                _s2P4Style = workbook.CreateCellStyle();
                _s4P4Style = workbook.CreateCellStyle();
                _s6P4Style = workbook.CreateCellStyle();
                _s7P4Style = workbook.CreateCellStyle();
                _s8P4Style = workbook.CreateCellStyle();
                _s9P4Style = workbook.CreateCellStyle();

                _totalStyle = workbook.CreateCellStyle();
                _reStyle = workbook.CreateCellStyle();
                _lengStyle = workbook.CreateCellStyle();
                _reLengTotalStyle = workbook.CreateCellStyle();
                _wuJiaoStyle = workbook.CreateCellStyle();
                _sanJiaoStyle = workbook.CreateCellStyle();
                _yuanStyle = workbook.CreateCellStyle();

                _s1P6Style = workbook.CreateCellStyle();
                _s2P6Style = workbook.CreateCellStyle();

                //https://www.cnblogs.com/love-zf/p/4874098.html
                _s2P1Style.FillForegroundColor = 13;
                _s4P1Style.FillForegroundColor = 22;
                _s6P1Style.FillForegroundColor = 45;
                _s7P1Style.FillForegroundColor = 22;
                _s8P1Style.FillForegroundColor = 45;

                _s2P2Style.FillForegroundColor = 40;
                _s4P2Style.FillForegroundColor = 55;
                _s6P2Style.FillForegroundColor = 41;
                _s7P2Style.FillForegroundColor = 55;
                _s8P2Style.FillForegroundColor = 41;

                _s2P3Style.FillForegroundColor = 13;
                _s4P3Style.FillForegroundColor = 22;
                _s6P3Style.FillForegroundColor = 45;
                _s7P3Style.FillForegroundColor = 22;
                _s8P3Style.FillForegroundColor = 45;

                _s2P4Style.FillForegroundColor = 40;
                _s4P4Style.FillForegroundColor = 55;
                _s6P4Style.FillForegroundColor = 41;
                _s7P4Style.FillForegroundColor = 55;
                _s8P4Style.FillForegroundColor = 41;

                _totalStyle.FillForegroundColor = 53;
                _reStyle.FillForegroundColor = 10;
                _lengStyle.FillForegroundColor = 40;
                _reLengTotalStyle.FillForegroundColor = 50;
                _wuJiaoStyle.FillForegroundColor = 43;
                _sanJiaoStyle.FillForegroundColor = 42;
                _yuanStyle.FillForegroundColor = 41;

                _s1P6Style.FillForegroundColor = 44;
                _s2P6Style.FillForegroundColor = 46;

                _s2P1Style.FillPattern = FillPattern.SolidForeground;
                _s4P1Style.FillPattern = FillPattern.SolidForeground;
                _s6P1Style.FillPattern = FillPattern.SolidForeground;
                _s7P1Style.FillPattern = FillPattern.SolidForeground;
                _s8P1Style.FillPattern = FillPattern.SolidForeground;

                _s2P2Style.FillPattern = FillPattern.SolidForeground;
                _s4P2Style.FillPattern = FillPattern.SolidForeground;
                _s6P2Style.FillPattern = FillPattern.SolidForeground;
                _s7P2Style.FillPattern = FillPattern.SolidForeground;
                _s8P2Style.FillPattern = FillPattern.SolidForeground;

                _s2P3Style.FillPattern = FillPattern.SolidForeground;
                _s4P3Style.FillPattern = FillPattern.SolidForeground;
                _s6P3Style.FillPattern = FillPattern.SolidForeground;
                _s7P3Style.FillPattern = FillPattern.SolidForeground;
                _s8P3Style.FillPattern = FillPattern.SolidForeground;

                _s2P4Style.FillPattern = FillPattern.SolidForeground;
                _s4P4Style.FillPattern = FillPattern.SolidForeground;
                _s6P4Style.FillPattern = FillPattern.SolidForeground;
                _s7P4Style.FillPattern = FillPattern.SolidForeground;
                _s8P4Style.FillPattern = FillPattern.SolidForeground;


                _totalStyle.FillPattern = FillPattern.SolidForeground;
                _reStyle.FillPattern = FillPattern.SolidForeground;
                _lengStyle.FillPattern = FillPattern.SolidForeground;
                _reLengTotalStyle.FillPattern = FillPattern.SolidForeground;
                _wuJiaoStyle.FillPattern = FillPattern.SolidForeground;
                _sanJiaoStyle.FillPattern = FillPattern.SolidForeground;
                _yuanStyle.FillPattern = FillPattern.SolidForeground;

                _s1P6Style.FillPattern = FillPattern.SolidForeground;
                _s2P6Style.FillPattern = FillPattern.SolidForeground;

                #endregion SetStyle

                ISheet sheet1 = workbook.CreateSheet("Sheet1");
                sheet1.DefaultColumnWidth = 1;
                sheet1.CreateRow(0).CreateCell(0).SetCellValue("This is a Sample");
                SetHeader(sheet1, 0);
                for (int i = _p1FirstRow; i < _context.Capacity + _p1FirstRow; i++)
                {
                    IRow row = sheet1.CreateRow(i);
                    var index = i - _p1FirstRow;
                    //   SetP1Value(row, index);

                    #region P1

                    SetP2Value(row, index);
                    //  SetP3Value(row, index);
                    SetP4Value(row, index);
                    //  SetP5Value(row, index);
                    SetP6Value(row, index);
                    SetP7Value(row, index);
                    SetP8Value(row, index);
                    SetP9Value(row, index);

                    #endregion P1

                    #region P2

                    Set2P2Value(row, index);
                    //  Set2P3Value(row, index);
                    Set2P4Value(row, index);
                    //   Set2P5Value(row, index);
                    Set2P6Value(row, index);
                    Set2P7Value(row, index);
                    Set2P8Value(row, index);
                    Set2P9Value(row, index);

                    #endregion P2

                    #region P3

                    Set3P2Value(row, index);
                    //  Set3P3Value(row, index);
                    Set3P4Value(row, index);
                    //   Set3P5Value(row, index);
                    Set3P6Value(row, index);
                    Set3P7Value(row, index);
                    Set3P8Value(row, index);
                    Set3P9Value(row, index);

                    #endregion P3

                    #region P4

                    Set4P2Value(row, index);
                    //  Set4P3Value(row, index);
                    Set4P4Value(row, index);
                    // Set4P5Value(row, index);
                    Set4P6Value(row, index);
                    Set4P7Value(row, index);
                    Set4P8Value(row, index);
                    Set4P9Value(row, index);

                    #endregion P4

                    #region P5
                    SetTotalValue(row, index);
                    SetReLengValue(row, index);
                    SetShapeValue(row, index);
                    #endregion

                    #region P6

                    SetS1S2P6Value(row,index);

                    #endregion

                }
                SaveFile(workbook);
            }
            catch (Exception ex)
            {
                Console.WriteLine("处理失败!");
                Console.WriteLine(ex.Message);
            }
        }

        private void SetHeader(ISheet sheet, int headerIndex)
        {
            var row = sheet.GetRow(headerIndex);
            _headerStyle.Alignment = HorizontalAlignment.Center;

            var s2p1 = row.CreateCell(0);
            var s4p1 = row.CreateCell(StepLength.P2);
            var s6p1 = row.CreateCell(StepLength.P2 + StepLength.P4);
            var s7p1 = row.CreateCell(StepLength.P2 + StepLength.P4 + StepLength.P6);
            var s8p1 = row.CreateCell(StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7);
            var s9p1 = row.CreateCell(StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8);

            s2p1.SetCellValue("一(2)");
            s4p1.SetCellValue("一(4)");
            s6p1.SetCellValue("一(6)");
            s7p1.SetCellValue("一(7)");
            s8p1.SetCellValue("一(8)");
            s9p1.SetCellValue("一(9)");

            s2p1.CellStyle = _headerStyle;
            s4p1.CellStyle = _headerStyle;
            s6p1.CellStyle = _headerStyle;
            s7p1.CellStyle = _headerStyle;
            s8p1.CellStyle = _headerStyle;
            s9p1.CellStyle = _headerStyle;

            var s2p2 = row.CreateCell(StepLength.DisplayTotal + 0);
            var s4p2 = row.CreateCell(StepLength.DisplayTotal + StepLength.P2);
            var s6p2 = row.CreateCell(StepLength.DisplayTotal + StepLength.P2 + StepLength.P4);
            var s7p2 = row.CreateCell(StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6);
            var s8p2 = row.CreateCell(StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7);
            var s9p2 = row.CreateCell(StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8);

            s2p2.SetCellValue("二(2)");
            s4p2.SetCellValue("二(4)");
            s6p2.SetCellValue("二(6)");
            s7p2.SetCellValue("二(7)");
            s8p2.SetCellValue("二(8)");
            s9p2.SetCellValue("二(9)");

            s2p2.CellStyle = _headerStyle;
            s4p2.CellStyle = _headerStyle;
            s6p2.CellStyle = _headerStyle;
            s7p2.CellStyle = _headerStyle;
            s8p2.CellStyle = _headerStyle;
            s9p2.CellStyle = _headerStyle;

            var s2p3 = row.CreateCell(2 * StepLength.DisplayTotal + 0);
            var s4p3 = row.CreateCell(2 * StepLength.DisplayTotal + StepLength.P2);
            var s6p3 = row.CreateCell(2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4);
            var s7p3 = row.CreateCell(2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6);
            var s8p3 = row.CreateCell(2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7);
            var s9p3 = row.CreateCell(2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8);

            s2p3.SetCellValue("三(2)");
            s4p3.SetCellValue("三(4)");
            s6p3.SetCellValue("三(6)");
            s7p3.SetCellValue("三(7)");
            s8p3.SetCellValue("三(8)");
            s9p3.SetCellValue("三(9)");

            s2p3.CellStyle = _headerStyle;
            s4p3.CellStyle = _headerStyle;
            s6p3.CellStyle = _headerStyle;
            s7p3.CellStyle = _headerStyle;
            s8p3.CellStyle = _headerStyle;
            s9p3.CellStyle = _headerStyle;

            var s2p4 = row.CreateCell(3 * StepLength.DisplayTotal + 0);
            var s4p4 = row.CreateCell(3 * StepLength.DisplayTotal + StepLength.P2);
            var s6p4 = row.CreateCell(3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4);
            var s7p4 = row.CreateCell(3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6);
            var s8p4 = row.CreateCell(3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7);
            var s9p4 = row.CreateCell(3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8);

            s2p4.SetCellValue("四(2)");
            s4p4.SetCellValue("四(4)");
            s6p4.SetCellValue("四(6)");
            s7p4.SetCellValue("四(7)");
            s8p4.SetCellValue("四(8)");
            s9p4.SetCellValue("四(9)");

            s2p4.CellStyle = _headerStyle;
            s4p4.CellStyle = _headerStyle;
            s6p4.CellStyle = _headerStyle;
            s7p4.CellStyle = _headerStyle;
            s8p4.CellStyle = _headerStyle;
            s9p4.CellStyle = _headerStyle;

            var totalCell = row.CreateCell(StepLength.DisplayTotal * 4);
            totalCell.SetCellValue("总和");
            totalCell.CellStyle = _headerStyle;

            var re = row.CreateCell(StepLength.DisplayTotal * 4 + 3);
            re.SetCellValue("热");
            re.CellStyle = _headerStyle;
            var leng = row.CreateCell(StepLength.DisplayTotal * 4 + 4);
            leng.SetCellValue("冷");
            leng.CellStyle = _headerStyle;
            var reLeng = row.CreateCell(StepLength.DisplayTotal * 4 + 5);
            reLeng.SetCellValue("和");
            reLeng.CellStyle = _headerStyle;
            var wuJiao = row.CreateCell(StepLength.DisplayTotal * 4 + 6);
            wuJiao.SetCellValue("★");
            wuJiao.CellStyle = _headerStyle;
            var sanJiao = row.CreateCell(StepLength.DisplayTotal * 4 + 7);
            sanJiao.SetCellValue("▲");
            sanJiao.CellStyle = _headerStyle;
            var yuan = row.CreateCell(StepLength.DisplayTotal * 4 + 8);
            yuan.SetCellValue("⚪");
            yuan.CellStyle = _headerStyle;
            var chong = row.CreateCell(StepLength.DisplayTotal * 4 + 9);
            chong.SetCellValue("重");
            chong.CellStyle = _headerStyle;
            var biao = row.CreateCell(StepLength.DisplayTotal * 4 + 10);
            biao.SetCellValue("标");
            biao.CellStyle = _headerStyle;
            var biaoSum = row.CreateCell(StepLength.DisplayTotal * 4 + 11);
            biaoSum.SetCellValue("Sum");
            biaoSum.CellStyle = _headerStyle;

            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 0, StepLength.P2 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.P2, StepLength.P2 + StepLength.P4 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.P2 + StepLength.P4, StepLength.P2 + StepLength.P4 + StepLength.P6 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.P2 + StepLength.P4 + StepLength.P6, StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7, StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8, StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 + StepLength.P9 - 1));

            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + 0, StepLength.DisplayTotal + StepLength.P2 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + StepLength.P2, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8, StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 + StepLength.P9 - 1));

            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + 0, 2 * StepLength.DisplayTotal + StepLength.P2 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + StepLength.P2, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8, 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 + StepLength.P9 - 1));

            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + 0, 3 * StepLength.DisplayTotal + StepLength.P2 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + StepLength.P2, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 - 1));
            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8, 3 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8 + StepLength.P9 - 1));

            sheet.AddMergedRegion(new CellRangeAddress(headerIndex, headerIndex, StepLength.DisplayTotal * 4, StepLength.DisplayTotal * 4 + 2));

            sheet.SetColumnWidth(StepLength.DisplayTotal * 4, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 1, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 2, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 3, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 4, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 5, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 6, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 7, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 8, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 9, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 10, 1000);
            sheet.SetColumnWidth(StepLength.DisplayTotal * 4 + 11, 1000);


        }

        #region SetP1Value

        private void SetP1Value(IRow row, int rowIndex)
        {
            for (int i = 0; i < StepLength.P1; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP1Value<int>(1, rowIndex, i));
            }
        }

        private void SetP2Value(IRow row, int rowIndex)
        {
            int beforeColumn = 0;
            for (int i = beforeColumn; i < StepLength.P2 + beforeColumn; i++)
            {
                var value = _context.GetP1Value<bool>(2, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s2P1Style;
                if (value)
                    cell.SetCellValue("🔺");
            }
        }

        private void SetP3Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P3 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP1Value<int>(3, rowIndex, i - beforeColumn));
            }
        }

        private void SetP4Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P4 + beforeColumn; i++)
            {
                var value = _context.GetP1Value<bool>(4, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s4P1Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void SetP5Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2 + StepLength.P3 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P5 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP1Value<int>(5, rowIndex, i - beforeColumn));
            }
        }

        private void SetP6Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P2 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P6 + beforeColumn; i++)
            {
                var value = _context.GetP1Value<bool>(6, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s6P1Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void SetP7Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P2 + StepLength.P4 + StepLength.P6;
            for (int i = beforeColumn; i < StepLength.P7 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP1Value<int>(7, rowIndex, i - beforeColumn));
                cell.CellStyle = _s7P1Style;
            }
        }

        private void SetP8Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7;
            for (int i = beforeColumn; i < StepLength.P8 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.CellStyle = _s8P1Style;
                cell.SetCellValue(_context.GetP1Value<int>(8, rowIndex, i - beforeColumn));
            }
        }

        private void SetP9Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8;
            for (int i = beforeColumn; i < StepLength.P9 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP1Value<int>(9, rowIndex, i - beforeColumn));
                cell.CellStyle = _s9P1Style;
            }
        }

        #endregion SetP1Value

        #region SetP2Value

        private void Set2P2Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal;
            for (int i = beforeColumn; i < StepLength.P2 + beforeColumn; i++)
            {
                var value = _context.GetP2Value<bool>(2, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s2P2Style;
                if (value)
                    cell.SetCellValue("⭕");
            }
        }

        private void Set2P3Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P3 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP2Value<int>(3, rowIndex, i - beforeColumn));
            }
        }

        private void Set2P4Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P4 + beforeColumn; i++)
            {
                var value = _context.GetP2Value<bool>(4, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s4P2Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set2P5Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2 + StepLength.P3 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P5 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP2Value<int>(5, rowIndex, i - beforeColumn));
            }
        }

        private void Set2P6Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P6 + beforeColumn; i++)
            {
                var value = _context.GetP2Value<bool>(6, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s6P2Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set2P7Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6;
            for (int i = beforeColumn; i < StepLength.P7 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP2Value<int>(7, rowIndex, i - beforeColumn));
                cell.CellStyle = _s7P2Style;
            }
        }

        private void Set2P8Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7;
            for (int i = beforeColumn; i < StepLength.P8 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.CellStyle = _s8P2Style;
                cell.SetCellValue(_context.GetP2Value<int>(8, rowIndex, i - beforeColumn));
            }
        }

        private void Set2P9Value(IRow row, int rowIndex)
        {
            int beforeColumn = 2 * StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8;
            for (int i = beforeColumn; i < StepLength.P9 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP2Value<int>(9, rowIndex, i - beforeColumn));
                cell.CellStyle = _s9P2Style;
            }
        }

        #endregion SetP2Value

        #region SetP3Value

        private void Set3P2Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal;
            for (int i = beforeColumn; i < StepLength.P2 + beforeColumn; i++)
            {
                var value = _context.GetP3Value<bool>(2, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s2P3Style;
                if (value)
                    cell.SetCellValue("▲");
            }
        }

        private void Set3P3Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P3 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP3Value<int>(3, rowIndex, i - beforeColumn));
            }
        }

        private void Set3P4Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P4 + beforeColumn; i++)
            {
                var value = _context.GetP3Value<bool>(4, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s4P3Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set3P5Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2 + StepLength.P3 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P5 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP3Value<int>(5, rowIndex, i - beforeColumn));
            }
        }

        private void Set3P6Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal + StepLength.P2 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P6 + beforeColumn; i++)
            {
                var value = _context.GetP3Value<bool>(6, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s6P3Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set3P7Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6;
            for (int i = beforeColumn; i < StepLength.P7 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP3Value<int>(7, rowIndex, i - beforeColumn));
                cell.CellStyle = _s7P3Style;
            }
        }

        private void Set3P8Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7;
            for (int i = beforeColumn; i < StepLength.P8 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.CellStyle = _s8P3Style;
                cell.SetCellValue(_context.GetP3Value<int>(8, rowIndex, i - beforeColumn));
            }
        }

        private void Set3P9Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8;
            for (int i = beforeColumn; i < StepLength.P9 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP3Value<int>(9, rowIndex, i - beforeColumn));
                cell.CellStyle = _s9P3Style;
            }
        }

        #endregion SetP3Value

        #region SetP4Value

        private void Set4P2Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3;
            for (int i = beforeColumn; i < StepLength.P2 + beforeColumn; i++)
            {
                var value = _context.GetP4Value<bool>(2, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s2P4Style;
                if (value)
                    cell.SetCellValue("⭕");
            }
        }

        private void Set4P3Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P3 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP4Value<int>(3, rowIndex, i - beforeColumn));
            }
        }

        private void Set4P4Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3 + StepLength.P2;
            for (int i = beforeColumn; i < StepLength.P4 + beforeColumn; i++)
            {
                var value = _context.GetP4Value<bool>(4, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s4P4Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set4P5Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.P1 + StepLength.P2 + StepLength.P3 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P5 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP4Value<int>(5, rowIndex, i - beforeColumn));
            }
        }

        private void Set4P6Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3 + StepLength.P2 + StepLength.P4;
            for (int i = beforeColumn; i < StepLength.P6 + beforeColumn; i++)
            {
                var value = _context.GetP4Value<bool>(6, rowIndex, i - beforeColumn);
                var cell = row.CreateCell(i);
                cell.CellStyle = _s6P4Style;
                if (value)
                    cell.SetCellValue(i - beforeColumn);
            }
        }

        private void Set4P7Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3 + StepLength.P2 + StepLength.P4 + StepLength.P6;
            for (int i = beforeColumn; i < StepLength.P7 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP4Value<int>(7, rowIndex, i - beforeColumn));
                cell.CellStyle = _s7P4Style;
            }
        }

        private void Set4P8Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3 + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7;
            for (int i = beforeColumn; i < StepLength.P8 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.CellStyle = _s8P4Style;
                cell.SetCellValue(_context.GetP4Value<int>(8, rowIndex, i - beforeColumn));
            }
        }

        private void Set4P9Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 3 + StepLength.P2 + StepLength.P4 + StepLength.P6 + StepLength.P7 + StepLength.P8;
            for (int i = beforeColumn; i < StepLength.P9 + beforeColumn; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP4Value<int>(9, rowIndex, i - beforeColumn));
                cell.CellStyle = _s9P4Style;
            }
        }

        #endregion SetP4Value

        #region SetP5Value

        private void SetTotalValue(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 4;
            for (int i = beforeColumn; i < beforeColumn + 3; i++)
            {
                var cell = row.CreateCell(i);
                cell.SetCellValue(_context.GetP5Value<int>(1, rowIndex, i - beforeColumn));
                cell.CellStyle = _totalStyle;
            }
        }

        private void SetReLengValue(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 4 + 3;
            var reCell = row.CreateCell(beforeColumn);
            reCell.SetCellValue(_context.GetP5Value<int>(2, rowIndex, 0));
            reCell.CellStyle = _reStyle;

            var lengCell = row.CreateCell(beforeColumn + 1);
            lengCell.SetCellValue(_context.GetP5Value<int>(2, rowIndex, 1));
            lengCell.CellStyle = _lengStyle;

            var reLengCell = row.CreateCell(beforeColumn + 2);
            reLengCell.SetCellValue(_context.GetP5Value<int>(2, rowIndex, 2));
            reLengCell.CellStyle = _reLengTotalStyle;
        }

        private void SetShapeValue(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 4 + 3 + 3;
            var wujiaoCell = row.CreateCell(beforeColumn);
            var sanjiaoCell = row.CreateCell(beforeColumn + 1);
            var yuanCell = row.CreateCell(beforeColumn + 2);
            var chongCell = row.CreateCell(beforeColumn + 3);

            wujiaoCell.SetCellValue(_context.GetP5Value<int>(3, rowIndex, 0));
            sanjiaoCell.SetCellValue(_context.GetP5Value<int>(3, rowIndex, 1));
            yuanCell.SetCellValue(_context.GetP5Value<int>(3, rowIndex, 2));
            chongCell.SetCellValue(_context.GetP5Value<int>(3, rowIndex, 3));

            wujiaoCell.CellStyle = _wuJiaoStyle;
            sanjiaoCell.CellStyle = _sanJiaoStyle;
            yuanCell.CellStyle = _yuanStyle;
            chongCell.CellStyle = _s8P1Style;
        }

        #endregion

        #region SetP6Value

        private void SetS1S2P6Value(IRow row, int rowIndex)
        {
            int beforeColumn = StepLength.DisplayTotal * 4 + 10;
            var biaoCell = row.CreateCell(beforeColumn);
            var biaoSumCell = row.CreateCell(beforeColumn + 1);

            biaoCell.SetCellValue(_context.GetP6Value<int>(1, rowIndex, 24));
            biaoSumCell.SetCellValue(_context.GetP6Value<int>(2, rowIndex, 0));

            biaoCell.CellStyle = _wuJiaoStyle;
            biaoSumCell.CellStyle = _sanJiaoStyle;
        }
        #endregion

        private void SaveFile(IWorkbook workBook)
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyy-MM-dd");
                var fullPath = path + "\\" + DateTime.Now.ToString("HH-mm-ss-ffff") + ".xlsx";
                if (!Directory.Exists(path))//如果不存在就创建file文件夹　　             　　
                    Directory.CreateDirectory(path);//创建该文件夹　　
                FileStream sw = File.Create(fullPath);
                workBook.Write(sw);
                sw.Close();
                // Process.Start("explorer.exe", "/select, \"" + fullPath + "\"");
                Process.Start(fullPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                throw;
            }
        }
    }
}