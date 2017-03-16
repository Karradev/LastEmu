using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class DebugClearHighlightCellsMessage : NetworkMessage
	{
		public const uint Id = 2002;

		public override uint ProtocolId
		{
			get
			{
				return (uint)2002;
			}
		}

		public DebugClearHighlightCellsMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}