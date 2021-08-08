fx_version 'cerulean'
game 'rdr3'

rdr3_warning 'I acknowledge that this is a prerelease build of RedM, and I am aware my resources *will* become incompatible once RedM ships.'

files {
	'CitizenFX.Core.dll',
	'Newtonsoft.Json.dll',
    'Ubiety.Dns.Core.dll',
    'libzstd.dll',
    'MySql.Data.dll',
	'RPShared.dll'
}

client_script 'RPClient.net.dll'
server_script 'RPServer.net.dll'
shared_script 'RPShared.dll'