using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class NewMailMessage : MailStatusMessage
	{
		public const uint Id = 6292;

		public int[] sendersAccountId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6292;
			}
		}

		public NewMailMessage()
		{
		}

		public NewMailMessage(uint unread, uint total, int[] sendersAccountId) : base(unread, total)
		{
			this.sendersAccountId = sendersAccountId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.sendersAccountId = new int[num];
			for (int i = 0; i < num; i++)
			{
				this.sendersAccountId[i] = reader.ReadInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.sendersAccountId.Length));
			int[] numArray = this.sendersAccountId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
		}
	}
}