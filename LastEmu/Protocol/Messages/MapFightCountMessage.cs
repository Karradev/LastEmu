using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MapFightCountMessage : NetworkMessage
	{
		public const uint Id = 210;

		public uint fightCount;

		public override uint ProtocolId
		{
			get
			{
				return (uint)210;
			}
		}

		public MapFightCountMessage()
		{
		}

		public MapFightCountMessage(uint fightCount)
		{
			this.fightCount = fightCount;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.fightCount = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.fightCount);
		}
	}
}