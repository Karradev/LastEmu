using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DungeonPartyFinderListenErrorMessage : NetworkMessage
	{
		public const uint Id = 6248;

		public uint dungeonId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6248;
			}
		}

		public DungeonPartyFinderListenErrorMessage()
		{
		}

		public DungeonPartyFinderListenErrorMessage(uint dungeonId)
		{
			this.dungeonId = dungeonId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
		}
	}
}