using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderRegisterRequestMessage : NetworkMessage
	{
		public const uint Id = 6249;

		public uint[] dungeonIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6249;
			}
		}

		public DungeonPartyFinderRegisterRequestMessage()
		{
		}

		public DungeonPartyFinderRegisterRequestMessage(uint[] dungeonIds)
		{
			this.dungeonIds = dungeonIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.dungeonIds = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.dungeonIds[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.dungeonIds.Length));
			uint[] numArray = this.dungeonIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}