using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DecraftResultMessage : NetworkMessage
	{
		public const uint Id = 6569;

		public DecraftedItemStackInfo[] results;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6569;
			}
		}

		public DecraftResultMessage()
		{
		}

		public DecraftResultMessage(DecraftedItemStackInfo[] results)
		{
			this.results = results;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.results = new DecraftedItemStackInfo[num];
			for (int i = 0; i < num; i++)
			{
				this.results[i] = new DecraftedItemStackInfo();
				this.results[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.results.Length));
			DecraftedItemStackInfo[] decraftedItemStackInfoArray = this.results;
			for (int i = 0; i < (int)decraftedItemStackInfoArray.Length; i++)
			{
				decraftedItemStackInfoArray[i].Serialize(writer);
			}
		}
	}
}