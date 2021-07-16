/**
 * Created by ghporras on 2021-07-15.
 */

/*
 Given a date string, , in the format MM/DD/YYYY, find and return the day name for that date.
 Each day name must be one of the following strings: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, or Saturday.
 For example, the day name for the date 12/07/2016 is Wednesday.
 */

// The days of the week are: "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
function getDayName(dateString) {
  let dayName;

  const userDate = new Date(dateString);
  switch (userDate.toDateString().substring(0, 3)) {
    case 'Sun':
      dayName = 'Sunday';
      break;
    case 'Mon':
      dayName = 'Monday';
      break;
    case 'Tue':
      dayName = 'Tuesday';
      break;
    case 'Wed':
      dayName = 'Wednesday';
      break;
    case 'Thu':
      dayName = 'Thursday';
      break;
    case 'Fri':
      dayName = 'Friday';
      break;
    case 'Sat':
      dayName = 'Saturday';
      break;
  }

  return dayName;
}
