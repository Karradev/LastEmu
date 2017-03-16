using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameFightOptionToggleMessage : NetworkMessage
	{
		public const uint Id = 707;

		public sbyte option;

		public override uint ProtocolId
		{
			get
			{
				return (uint)707;
			}
		}

		public GameFightOptionToggleMessage()
		{
		}

		public GameFightOptionToggleMessage(sbyte option)
		{
			this.option = option;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.option = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.option);
		}
	}
}