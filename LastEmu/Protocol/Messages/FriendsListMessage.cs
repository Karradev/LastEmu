using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class FriendsListMessage : NetworkMessage
	{
		public const uint Id = 4002;

		public FriendInformations[] friendsList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)4002;
			}
		}

		public FriendsListMessage()
		{
		}

		public FriendsListMessage(FriendInformations[] friendsList)
		{
			this.friendsList = friendsList;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.friendsList = new FriendInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.friendsList[i] = ProtocolTypeManager.GetInstance<FriendInformations>(reader.ReadUShort());
				this.friendsList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.friendsList.Length));
			FriendInformations[] friendInformationsArray = this.friendsList;
			for (int i = 0; i < (int)friendInformationsArray.Length; i++)
			{
				FriendInformations friendInformation = friendInformationsArray[i];
				writer.WriteShort(friendInformation.TypeId);
				friendInformation.Serialize(writer);
			}
		}
	}
}