from pytrends.request import TrendReq
import json
import sys

google_username = "kk1johnson@gmail.com"
google_password = "johnson3"
path = ""
useragent = "Mozilla//5.0"
query = sys.argv[1:]

# connect to Google
pytrend = TrendReq(google_username, google_password, custom_useragent = useragent)

# get two years of weekly trends
trend_payload = {'q': query, 'date': 'today 24-m'}

# trend
trend = pytrend.trend(trend_payload, return_type = "json")
# print(trend)

print(json.dumps(trend))

# json.dump(trend,f)





# response = pytrend.trend(trend_payload, return_type='json')
# print(response)


# # toprelated
# toprelated = pytrend.related(trend_payload, related_type='top')
# print(toprelated)
# risingrelated = pytrend.related(trend_payload, related_type='rising')
# print(risingrelated)

# # top30in30
# top30in30 = pytrend.top30in30()
# print(top30in30)

# country_payload = {'geo': 'US'}
# # hottrends
# hottrends = pytrend.hottrends(country_payload)
# print(hottrends)

# # hottrendsdetail
# # returns XML data
# hottrendsdetail = pytrend.hottrendsdetail(country_payload)
# print(hottrendsdetail)

# payload = {'date': '201601', 'geo': 'US'}
# # alltopcharts
# topcharts = pytrend.topcharts(payload)
# print(topcharts)

# keyword = 'pizza'
# # suggestions
# suggestions = pytrend.suggestions(keyword)
# print(suggestions)

