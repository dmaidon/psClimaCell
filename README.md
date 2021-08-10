# Tomorrow.io V4 #

A Windows Desktop application that utilizes [Tomorrow.io V4 API](https://developer.climacell.co/) TimeLine forecasts.  Supports "best", "current", "1d", "1h", "30m", "15m", "5m" and "1m" timelines.

A separate tab is provided for each data timeline.

Core, Air Quality, Fire, Land, Maritime, Pollen, Precipitation and Solar data is supported.

Written in Vb.Net 4.8 Framework.

Requires a V4 API Key from http://tomorrow.io

## Features ##

- [ ] Updates every hour at 15 seconds past the hour.
- [ ] Easily select whick fields to download. (Max: 50)
- [ ] Easily select which timlines to download. (Max: 3)
- [ ] Runs an event at midnight to clear the log files and start a new one
- [ ] Separate log files for any errors and debug information


Following sections were added to Imperial and Metric Field Units Json files.

<pre>
 "_epaComment": "EpsBgColor, EpaFgColor and EpaConcernText added to enhance AQI data response.",
  "EpaBgColor": {
    "0": "#00E400",
    "1": "#FFFF00",
    "2": "#FF7E00",
    "3": "#FF0000",
    "4": "#8F3F97",
    "5": "#7E0023"
  },
  "EpaFgColor": {
    "0": "#000000",
    "1": "#000000",
    "2": "#000000",
    "3": "#000000",
    "4": "##E6E6FA",
    "5": "##E6E6FA"
  },
  "EpaConcernText": {
    "0": "(0-50)  Air quality is satisfactory and poses little or no health risk.",
    "1": "(51-100)  Air quality is acceptable; however, pollution in this range may pose\n a moderate health concern for a very small number of individuals. People\n who are unusually sensitive to ozone or particle pollution may experience\n respiratory symptoms.",
    "2": "(101-150)  Members of sensitive groups may experience health effects, but the\n general public is unlikely to be affected.",
    "3": "(151-200)  Everyone may begin to experience health effects but members of sensitive\n groups may experience more serious health effects.",
    "4": "(201-300)  Values Trigger a health alert, meaning everyone may experience more\n serious health effects.",
    "5": "(300+)  AQI values over 300 trigger health warnings of emergency conditions. The\n entire population is even more likely to be affected by serious health\n effects."
  },
</pre>

The following sections were added to the FieldUnitsModel.vb file

<pre>
 Public Property EpaBgColor() As Dictionary(Of String, String)
 Public Property EpaFgColor() As Dictionary(Of String, String)
 Public Property EpaConcernText() As Dictionary(Of String, String)
</pre>

The V4 code is not complete for all data streams.  Any contributors are welcome.

# ClimaCell V3 #
## Deprecated ##
Utilizes [ClimaCell V3 API](https://developer.climacell.co/) 15-day Daily forecast, Nowcast, Realtime and Hourly forecasts.

### Notice: Version 3 will sunset on June 21, 2021 and all requests will fail. ###

### What's Included: ###
- [ ] [Daily](https://developer.climacell.co/v3/reference#get-daily)
- [ ] [Hourly](https://developer.climacell.co/v3/reference#get-hourly)
- [ ] [Nowcast](https://developer.climacell.co/v3/reference#get-nowcast)
- [ ] [Realtime](https://developer.climacell.co/v3/reference#get-realtime)

Requires a V3 API Key from http://climacell.co.

Utilizes System.Text.Json instead of Newtonsoft.Json

VB.Net 4.8 .Net Framework

Configurable as to what data you wish to download.

### License ###
Licensed under the MIT license.

Powered by Climacell
