import requests

# The API endpoint
url = "https://api.hacienda.go.cr/fe/ae?identificacion=701850132"

# A GET request to the API
response = requests.get(url)

# Print the response
response_json = response.json()
print(response_json)

"""
{'userId': 1, 'id': 1, 'title': 'sunt aut facere repellat provident occaecati excepturi optio reprehenderit', 'body': 'quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto'}
"""