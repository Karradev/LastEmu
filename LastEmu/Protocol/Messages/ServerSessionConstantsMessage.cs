using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ServerSessionConstantsMessage : NetworkMessage
	{
		public const uint Id = 6434;

		public ServerSessionConstant[] variables;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6434;
			}
		}

		public ServerSessionConstantsMessage()
		{
		}

		public ServerSessionConstantsMessage(ServerSessionConstant[] variables)
		{
			this.variables = variables;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.variables = new ServerSessionConstant[num];
			for (int i = 0; i < num; i++)
			{
				this.variables[i] = ProtocolTypeManager.GetInstance<ServerSessionConstant>(reader.ReadUShort());
				this.variables[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.variables.Length));
			ServerSessionConstant[] serverSessionConstantArray = this.variables;
			for (int i = 0; i < (int)serverSessionConstantArray.Length; i++)
			{
				ServerSessionConstant serverSessionConstant = serverSessionConstantArray[i];
				writer.WriteShort(serverSessionConstant.TypeId);
				serverSessionConstant.Serialize(writer);
			}
		}
	}
}