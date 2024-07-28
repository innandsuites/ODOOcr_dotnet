import xmlrpc.client
import credential
#info = xmlrpc.client.ServerProxy('https://sunombre.odoo.com').start()


common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(credential.url))
#common.version()
#print(common.version())
uid = common.authenticate(credential.db, credential.username, credential.password, {})

models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(credential.url))
cadena = models.execute_kw(credential.db, uid, credential.password, 'pos.order.line', 'search_read', [[['write_date', '>', '2024-06-08']]], {'fields': ['name', 'qty', 'total_cost'], 'limit': 5})

print(cadena)