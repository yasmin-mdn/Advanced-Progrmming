class Person:
    def __init__(self,id,name,contacts,chats):
        self.ID=id
        self.Name=name
        self.Contacts=contacts
        self.Chats=chats
        x=1

    def AddContact(self,PERSON):
        for p in self.Contacts :
            if p==PERSON:
             return 0
         
        self.Contacts.append(PERSON)
        return 0

    def SendMessage(self,message):
        des=False
        so=False
        for p in message.Source.Contacts:
            if p==message.Destination:
                des=True
        if des==False:
            message.Source.Contacts.append(message.Destination)
            des=True

        for p in message.Destination.Contacts:
            if p==message.Source:
                so=True
        if so==False:
            message.Destination.Contacts.append(message.Source)
            so=True

        if des==True and so==True:
         message.Source.Chats[message.Destination.ID]=[message]
         message.Destination.Chats[message.Source.ID]=[message]
        return 0 

class Message:
    def __init__(self,source,destination,context):
        self.Source=source
        self.Destination=destination
        self.Context=context
        x=1


