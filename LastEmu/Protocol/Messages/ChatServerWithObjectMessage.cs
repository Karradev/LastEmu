using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ChatServerWithObjectMessage : ChatServerMessage
	{
		public const uint Id = 883;

		public ObjectItem[] objects;

		public override uint ProtocolId
		{
			get
			{
				return (uint)883;
			}
		}

		public ChatServerWithObjectMessage()
		{
		}

		public ChatServerWithObjectMessage(sbyte channel, string content, int timestamp, string fingerprint, double senderId, string senderName, int senderAccountId, ObjectItem[] objects) : base(channel, content, timestamp, fingerprint, senderId, senderName, senderAccountId)
		{
			this.objects = objects;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.objects = new ObjectItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objects[i] = new ObjectItem();
				this.objects[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.objects.Length));
			ObjectItem[] objectItemArray = this.objects;
			for (int i = 0; i < (int)objectItemArray.Length; i++)
			{
				objectItemArray[i].Serialize(writer);
			}
		}
	}
}