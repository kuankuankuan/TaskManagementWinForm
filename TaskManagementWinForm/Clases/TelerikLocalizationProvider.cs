using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace TaskManagementWinForm.Clases
{
    public class RussianDataFilterLocalizationProvider : DataFilterLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case DataFilterStringId.LogicalOperatorAnd:
                    return "Все";
                case DataFilterStringId.LogicalOperatorOr:
                    return "Любой";
                case DataFilterStringId.LogicalOperatorDescription:
                    return "Истина";

                case DataFilterStringId.FieldNullText:
                    return "Выберите";
                case DataFilterStringId.ValueNullText:
                    return "Выберите";

                case DataFilterStringId.AddNewButtonText:
                    return "Добавить";
                case DataFilterStringId.AddNewButtonExpression:
                    return "Выражение";
                case DataFilterStringId.AddNewButtonGroup:
                    return "Группа";

                case DataFilterStringId.DialogTitle:
                    return "Фильтр";
                case DataFilterStringId.DialogOKButton:
                    return "OK";
                case DataFilterStringId.DialogCancelButton:
                    return "Отменить";
                case DataFilterStringId.DialogApplyButton:
                    return "Применить";

                case DataFilterStringId.ErrorAddNodeDialogTitle:
                    return "Ошибка";
                case DataFilterStringId.ErrorAddNodeDialogText:
                    return "Cannot add entries to the control - missing property descriptors. \nDataSource is not set and/or DataFilterDescriptorItems are not added to the Descriptors collection of the control.";

                case DataFilterStringId.FilterFunctionBetween:
                    return "Между";
                case DataFilterStringId.FilterFunctionContains:
                    return "~";
                case DataFilterStringId.FilterFunctionDoesNotContain:
                    return "не ~";
                case DataFilterStringId.FilterFunctionEndsWith:
                    return "Заканчивается";
                case DataFilterStringId.FilterFunctionEqualTo:
                    return "=";
                case DataFilterStringId.FilterFunctionGreaterThan:
                    return ">";
                case DataFilterStringId.FilterFunctionGreaterThanOrEqualTo:
                    return ">=";
                case DataFilterStringId.FilterFunctionIsEmpty:
                    return "Пусто";
                case DataFilterStringId.FilterFunctionIsNull:
                    return "Пусто";
                case DataFilterStringId.FilterFunctionLessThan:
                    return "<";
                case DataFilterStringId.FilterFunctionLessThanOrEqualTo:
                    return "<=";
                case DataFilterStringId.FilterFunctionNoFilter:
                    return "Без фильтра";
                case DataFilterStringId.FilterFunctionNotBetween:
                    return "Не между";
                case DataFilterStringId.FilterFunctionNotEqualTo:
                    return "<>";
                case DataFilterStringId.FilterFunctionNotIsEmpty:
                    return "Не пусто";
                case DataFilterStringId.FilterFunctionNotIsNull:
                    return "Пусто";
                case DataFilterStringId.FilterFunctionStartsWith:
                    return "Начинается с";
                case DataFilterStringId.FilterFunctionCustom:
                    return "Пользовательский";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class RussianRadGridLocalizationProvider : RadGridLocalizationProvider
        {
            public override string GetLocalizedString(string id)
            {
                switch (id)
                {
                    case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Выберите значение";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Выберите значение";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Введите значения";
                    case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Введите выражение";
                    case RadGridStringId.ConditionalFormattingItem: return "Элемент";
                    case RadGridStringId.ConditionalFormattingInvalidParameters: return "Неверный параметр";
                    case RadGridStringId.FilterFunctionBetween: return "Между";
                    case RadGridStringId.FilterFunctionContains: return "~ ";
                    case RadGridStringId.FilterFunctionDoesNotContain: return "!~ ";
                    case RadGridStringId.FilterFunctionEndsWith: return "Заканчиваетс на";
                    case RadGridStringId.FilterFunctionEqualTo: return "= ";
                    case RadGridStringId.FilterFunctionGreaterThan: return "> ";
                    case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return ">= ";
                    case RadGridStringId.FilterFunctionIsEmpty: return "Пусто";
                    case RadGridStringId.FilterFunctionIsNull: return "Пусто";
                    case RadGridStringId.FilterFunctionLessThan: return "<";
                    case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "<= ";
                    case RadGridStringId.FilterFunctionNoFilter: return "Без фильтра";
                    case RadGridStringId.FilterFunctionNotBetween: return "Не между";
                    case RadGridStringId.FilterFunctionNotEqualTo: return "<> ";
                    case RadGridStringId.FilterFunctionNotIsEmpty: return "Не пусто";
                    case RadGridStringId.FilterFunctionNotIsNull: return "Не пусто";
                    case RadGridStringId.FilterFunctionStartsWith: return "Начинается с";
                    case RadGridStringId.FilterFunctionCustom: return "Пользовательский";
                    case RadGridStringId.FilterOperatorBetween: return "Между";
                    case RadGridStringId.FilterOperatorContains: return "~ ";
                    case RadGridStringId.FilterOperatorDoesNotContain: return "!~ ";
                    case RadGridStringId.FilterOperatorEndsWith: return "Заканчивается на";
                    case RadGridStringId.FilterOperatorEqualTo: return "= ";
                    case RadGridStringId.FilterOperatorGreaterThan: return "> ";
                    case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return ">= ";
                    case RadGridStringId.FilterOperatorIsEmpty: return "Пусто";
                    case RadGridStringId.FilterOperatorIsNull: return "Пусто";
                    case RadGridStringId.FilterOperatorLessThan: return "< ";
                    case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "<= ";
                    case RadGridStringId.FilterOperatorNoFilter: return "Без фильтра";
                    case RadGridStringId.FilterOperatorNotBetween: return "Не между";
                    case RadGridStringId.FilterOperatorNotEqualTo: return "<>";
                    case RadGridStringId.FilterOperatorNotIsEmpty: return "Не пусто";
                    case RadGridStringId.FilterOperatorNotIsNull: return "Не пусто";
                    case RadGridStringId.FilterOperatorStartsWith: return "Начинается с";
                    case RadGridStringId.FilterOperatorIsLike: return "~ ";
                    case RadGridStringId.FilterOperatorNotIsLike: return "!~ ";
                    case RadGridStringId.FilterOperatorIsContainedIn: return "Содержится в";
                    case RadGridStringId.FilterOperatorNotIsContainedIn: return "Не содержится в";
                    case RadGridStringId.FilterOperatorCustom: return "Пользовательский";
                    case RadGridStringId.CustomFilterMenuItem: return "Пользовательский";
                    case RadGridStringId.CustomFilterDialogCaption: return "Пользовательский фильтр [{0}]";
                    case RadGridStringId.CustomFilterDialogLabel: return "Показать строки:";
                    case RadGridStringId.CustomFilterDialogRbAnd: return "И";
                    case RadGridStringId.CustomFilterDialogRbOr: return "Или";
                    case RadGridStringId.CustomFilterDialogBtnOk: return "Применить";
                    case RadGridStringId.CustomFilterDialogBtnCancel: return "Отмена";
                    case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Нет";
                    case RadGridStringId.CustomFilterDialogTrue: return "Истина";
                    case RadGridStringId.CustomFilterDialogFalse: return "Ложь";
                    case RadGridStringId.FilterMenuBlanks: return "Пусто";
                    case RadGridStringId.FilterMenuAvailableFilters: return "Доступные фильтры";
                    case RadGridStringId.FilterMenuSearchBoxText: return "Поиск...";
                    case RadGridStringId.FilterMenuClearFilters: return "Обнулить фильтр";
                    case RadGridStringId.FilterMenuButtonOK: return "Применить";
                    case RadGridStringId.FilterMenuButtonCancel: return "Отменить";
                    case RadGridStringId.FilterMenuSelectionAll: return "Все";
                    case RadGridStringId.FilterMenuSelectionAllSearched: return "Результаты";
                    case RadGridStringId.FilterMenuSelectionNull: return "Пусто";
                    case RadGridStringId.FilterMenuSelectionNotNull: return "Не пусто";
                    case RadGridStringId.FilterFunctionSelectedDates: return "Фильтр по указанным датам:";
                    case RadGridStringId.FilterFunctionToday: return "Сегодня";
                    case RadGridStringId.FilterFunctionYesterday: return "Вчера";
                    case RadGridStringId.FilterFunctionDuringLast7days: return "Последние 7 дней";
                    case RadGridStringId.FilterLogicalOperatorAnd: return "И";
                    case RadGridStringId.FilterLogicalOperatorOr: return "Или";
                    case RadGridStringId.FilterCompositeNotOperator: return "Нет";
                    case RadGridStringId.DeleteRowMenuItem: return "Удалить строку";
                    case RadGridStringId.SortAscendingMenuItem: return "По возрастанию";
                    case RadGridStringId.SortDescendingMenuItem: return "По убыванию";
                    case RadGridStringId.ClearSortingMenuItem: return "Обнулить сортировку";
                    case RadGridStringId.ConditionalFormattingMenuItem: return "Формат";
                    case RadGridStringId.GroupByThisColumnMenuItem: return "Группировать по данному столбцу";
                    case RadGridStringId.UngroupThisColumn: return "Отменить группировку по данному столбцу";
                    case RadGridStringId.ColumnChooserMenuItem: return "Настройка столбцов";
                    case RadGridStringId.HideMenuItem: return "Скрыть столбец";
                    case RadGridStringId.HideGroupMenuItem: return "Скрыть группу";
                    case RadGridStringId.UnpinMenuItem: return "Открепить столбец";
                    case RadGridStringId.UnpinRowMenuItem: return "Открепить строку";
                    case RadGridStringId.PinMenuItem: return "Состояние закрепления";
                    case RadGridStringId.PinAtLeftMenuItem: return "Закрепить слева";
                    case RadGridStringId.PinAtRightMenuItem: return "Закрепить справа";
                    case RadGridStringId.PinAtBottomMenuItem: return "Закреить снизу";
                    case RadGridStringId.PinAtTopMenuItem: return "Закреить сверху";
                    case RadGridStringId.BestFitMenuItem: return "Наиболее подходящая ширина";
                    case RadGridStringId.PasteMenuItem: return "Вставить";
                    case RadGridStringId.EditMenuItem: return "Редактировать";
                    case RadGridStringId.ClearValueMenuItem: return "Обнулить значение";
                    case RadGridStringId.CopyMenuItem: return "Копировать";
                    case RadGridStringId.CutMenuItem: return "Вырезать";
                    case RadGridStringId.AddNewRowString: return "Нажмите сюда для добавления строки";
                    case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Отсортировать столбцы по алфавиту";
                    case RadGridStringId.ConditionalFormattingCaption: return "Менеджер правил условного форматирования";
                    case RadGridStringId.ConditionalFormattingLblColumn: return "Форматировать только ячейки с";
                    case RadGridStringId.ConditionalFormattingLblName: return "Название правила";
                    case RadGridStringId.ConditionalFormattingLblType: return "Значение ячейки";
                    case RadGridStringId.ConditionalFormattingLblValue1: return "Значение 1";
                    case RadGridStringId.ConditionalFormattingLblValue2: return "Значение 2";
                    case RadGridStringId.ConditionalFormattingGrpConditions: return "Правила";
                    case RadGridStringId.ConditionalFormattingGrpProperties: return "Свойства правила";
                    case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Примените это форматирование ко всей строке";
                    case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Примените это форматирование, если строка выбрана";
                    case RadGridStringId.ConditionalFormattingBtnAdd: return "Добавить новое правило";
                    case RadGridStringId.ConditionalFormattingBtnRemove: return "Удалить";
                    case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                    case RadGridStringId.ConditionalFormattingBtnCancel: return "Отмена";
                    case RadGridStringId.ConditionalFormattingBtnApply: return "Применять";
                    case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Правило относится к";
                    case RadGridStringId.ConditionalFormattingCondition: return "Состояние";
                    case RadGridStringId.ConditionalFormattingExpression: return "Выражение";
                    case RadGridStringId.ConditionalFormattingChooseOne: return "[Выберите один]";
                    case RadGridStringId.ConditionalFormattingEqualsTo: return "равно [Значение1]";
                    case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "не равно [Value1]";
                    case RadGridStringId.ConditionalFormattingStartsWith: return "начинается с [Value1]";
                    case RadGridStringId.ConditionalFormattingEndsWith: return "заканчивается на [Value1]";
                    case RadGridStringId.ConditionalFormattingContains: return "содержит [Value1]";
                    case RadGridStringId.ConditionalFormattingDoesNotContain: return "не содержит [Value1]";
                    case RadGridStringId.ConditionalFormattingIsGreaterThan: return "больше чем [Value1]";
                    case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "больше или равно [Value1]";
                    case RadGridStringId.ConditionalFormattingIsLessThan: return "меньше чем [Value1]";
                    case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "меньше или равно [Value1]";
                    case RadGridStringId.ConditionalFormattingIsBetween: return "находится между [Value1] и [Value2]";
                    case RadGridStringId.ConditionalFormattingIsNotBetween: return "не находится между [Value1] и [Value1]";
                    case RadGridStringId.ConditionalFormattingLblFormat: return "Format";
                    case RadGridStringId.ConditionalFormattingBtnExpression: return "Редактор выражений";
                    case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Выражение";
                    case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "CaseSensitive";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "CellBackColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "CellForeColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Enabled";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "RowBackColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "RowForeColor";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "Выравнивание текста строки";
                    case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "Выравнивание текста";
                    case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Determines whether case-sensitive comparisons will be made when evaluating string values.";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Введите цвет фона, который будет использоваться для ячейки.";
                    case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Введите цвет переднего плана, который будет использоваться для ячейки.";
                    case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Определяет, включено ли условие (можно оценить и применить).";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Введите цвет фона, который будет использоваться для всей строки.";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Введите цвет переднего плана, который будет использоваться для всей строки.";
                    case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Введите выравнивание, которое будет использоваться для значений ячеек, когда ApplyToRow равно true.";
                    case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Введите выравнивание, которое будет использоваться для значений ячеек.";
                    case RadGridStringId.ColumnChooserFormCaption: return "Столбцы";
                    case RadGridStringId.ColumnChooserFormMessage: return "Перетащите заголовок столбца из сетки \n сюда, чтобы удалить его из \n текущего представления.";
                    case RadGridStringId.GroupingPanelDefaultMessage: return "Перетащите столбец сюда для группировки по нему.";
                    case RadGridStringId.GroupingPanelHeader: return "Группировать по:";
                    case RadGridStringId.PagingPanelPagesLabel: return "Страница";
                    case RadGridStringId.PagingPanelOfPagesLabel: return "of";
                    case RadGridStringId.NoDataText: return "Нет данных для отображения";
                    case RadGridStringId.CompositeFilterFormErrorCaption: return "Ошибка фильтра";
                    case RadGridStringId.CompositeFilterFormInvalidFilter: return "Дескриптор составного фильтра недопустим.";
                    case RadGridStringId.ExpressionMenuItem: return "Выражение";
                    case RadGridStringId.ExpressionFormTitle: return "Построитель выражений";
                    case RadGridStringId.ExpressionFormFunctions: return "Функции";
                    case RadGridStringId.ExpressionFormFunctionsText: return "Текст";
                    case RadGridStringId.ExpressionFormFunctionsAggregate: return "Aggregate";
                    case RadGridStringId.ExpressionFormFunctionsDateTime: return "Дата-Время";
                    case RadGridStringId.ExpressionFormFunctionsLogical: return "Логический";
                    case RadGridStringId.ExpressionFormFunctionsMath: return "Math";
                    case RadGridStringId.ExpressionFormFunctionsOther: return "Other";
                    case RadGridStringId.ExpressionFormOperators: return "Операторы";
                    case RadGridStringId.ExpressionFormConstants: return "Контакты";
                    case RadGridStringId.ExpressionFormFields: return "Поля";
                    case RadGridStringId.ExpressionFormDescription: return "Описание";
                    case RadGridStringId.ExpressionFormResultPreview: return "Result preview";
                    case RadGridStringId.ExpressionFormTooltipPlus: return "Плюс";
                    case RadGridStringId.ExpressionFormTooltipMinus: return "Минус";
                    case RadGridStringId.ExpressionFormTooltipMultiply: return "Умножить";
                    case RadGridStringId.ExpressionFormTooltipDivide: return "Делить";
                    case RadGridStringId.ExpressionFormTooltipModulo: return "Modulo";
                    case RadGridStringId.ExpressionFormTooltipEqual: return "Равно";
                    case RadGridStringId.ExpressionFormTooltipNotEqual: return "Не равно";
                    case RadGridStringId.ExpressionFormTooltipLess: return "Меньше";
                    case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Меньше или равно";
                    case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Больше или равно";
                    case RadGridStringId.ExpressionFormTooltipGreater: return "Больше";
                    case RadGridStringId.ExpressionFormTooltipAnd: return "Логическое \"И\"";
                    case RadGridStringId.ExpressionFormTooltipOr: return "Логическое \"ИЛИ\"";
                    case RadGridStringId.ExpressionFormTooltipNot: return "Логическое \"НЕТ\"";
                    case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                    case RadGridStringId.ExpressionFormOKButton: return "Применить";
                    case RadGridStringId.ExpressionFormCancelButton: return "Отменить";
                    case RadGridStringId.SearchRowChooseColumns: return "Строка поиска...";
                    case RadGridStringId.SearchRowSearchFromCurrentPosition: return "Строка поиска...";
                    case RadGridStringId.SearchRowMenuItemMasterTemplate: return "Строка поиска...";
                    case RadGridStringId.SearchRowMenuItemChildTemplates: return "Строка поиска...";
                    case RadGridStringId.SearchRowMenuItemAllColumns: return "Строка поиска...";
                    case RadGridStringId.SearchRowTextBoxNullText: return "Строка поиска...";
                    case RadGridStringId.SearchRowResultsOfLabel: return "Строка поиска...";
                    case RadGridStringId.SearchRowMatchCase: return "Match case";
                }
                return string.Empty;
            }
        }
}
