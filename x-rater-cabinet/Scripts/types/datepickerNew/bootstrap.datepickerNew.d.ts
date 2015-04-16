// Type definitions for bootstrap.datepicker
// Project: https://github.com/eternicode/bootstrap-datepicker
// Definitions by: Boris Yankov <https://github.com/borisyankov/>
// Definitions: https://github.com/borisyankov/DefinitelyTyped

/// <reference path="../jquery/jquery.d.ts"/>

/**
 * All options that take a “Date” can handle a Date object; a String
 * formatted according to the given format; or a timedelta relative
 * to today, eg “-1d”, “+6m +1y”, etc, where valid units are “d” (day),
 * “w” (week), “m” (month), and “y” (year).
 * 
 * See online docs for more info:
 *  http://bootstrap-datepicker.readthedocs.org/en/release/options.html
 */
interface datepickerNewOptions {
    format?: string;
    weekStart?: number;
    startDate?: any;
    endDate?: any;
    autoclose?: boolean;
    startView?: number;
    todayBtn?: any;
    todayHighlight?: boolean;
    keyboardNavigation?: boolean;
    language?: string;
    beforeShowDay?: (date: any) => any;
    calendarWeeks?: boolean;
    clearBtn?: boolean;
    daysOfWeekDisabled?: number[];
    forceParse?: boolean;
    inputs?: any[];
    minViewMode?: any;
    multidate?: any;
    multidateSeparator?: string;
    orientation?: string;
}

interface datepickerNewEventObject extends JQueryEventObject {
    date: Date;
    format(format?: string): string;
}

interface JQuery {
    datepickerNew(): JQuery;
    datepickerNew(methodName: string): JQuery;
    datepickerNew(methodName: string, params: any): JQuery;
    datepickerNew(options: datepickerNewOptions): JQuery;

    off(events: "changeDate", selector?: string, handler?: (eventObject: datepickerNewEventObject) => any): JQuery;
    off(events: "changeDate", handler: (eventObject: datepickerNewEventObject) => any): JQuery;

    on(events: "changeDate", selector: string, data: any, handler?: (eventObject: datepickerNewEventObject) => any): JQuery;
    on(events: "changeDate", selector: string, handler: (eventObject: datepickerNewEventObject) => any): JQuery;
    on(events: 'changeDate', handler: (eventObject: datepickerNewEventObject) => any): JQuery;
}
