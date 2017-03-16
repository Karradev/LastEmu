using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AcquaintanceServerListMessage : NetworkMessage
	{
		public const uint Id = 6142;

		public uint[] servers;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6142;
			}
		}

		public AcquaintanceServerListMessage()
		{
		}

		public AcquaintanceServerListMessage(uint[] servers)
		{
			this.servers = servers;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.servers = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.servers[i] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.servers.Length));
			uint[] numArray = this.servers;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
		}
	}
}