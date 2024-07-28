import xmlrpc.client
import credential
#info = xmlrpc.client.ServerProxy('https://sunombre.odoo.com').start()


common = xmlrpc.client.ServerProxy('{}/xmlrpc/2/common'.format(credential.url))
common.version()
#print(common.version())
uid = common.authenticate(credential.db, credential.username, credential.password, {})

models = xmlrpc.client.ServerProxy('{}/xmlrpc/2/object'.format(credential.url))
cadena = models.execute_kw(credential.db, uid, credential.password, 'res.partner', 'check_access_rights', ['read'], {'raise_exception': False})
print(cadena)